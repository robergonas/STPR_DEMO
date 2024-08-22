using STPR_UI.Entidad;
using STPR_UI.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.Rest.Voice.V1.DialingPermissions.Country;
using Twilio.TwiML.Messaging;

namespace STPR_UI
{
    public partial class frmGenerarCita : Form
    {
        public int idPaciente = 0;
        public string datosPaciente = string.Empty;
        public int idStpr = 0;
        public string telefono = string.Empty;
        public string correo = string.Empty;
        public frmGenerarCita(List<tm_tratamientoBE> listaTratamiento)
        {
            InitializeComponent();
            lblDatosPacienteGenerar.Text = datosPaciente;

            CargarTratamiento(listaTratamiento);
            CargarCanales();
        }
        private void CargarCanales()
        {
            var mensajeRetorno = string.Empty;
            var objStpr = new tm_stprBL().GetStpr(idStpr, out mensajeRetorno);

            chkSMS.Visible = objStpr.sms;
            chkMultimedia.Visible = objStpr.multimedia;
            chkCorreo.Visible = objStpr.mail;
        }
        private void CargarTratamiento(List<tm_tratamientoBE> listaTratamiento)
        {
            var mensajeRetorno = string.Empty;
            //List<tm_tratamientoBE> listaTratamiento = new tm_tratamientoBL().GetTratamiento(idPaciente, 0, out mensajeRetorno);
            listaTratamiento.Insert(0, new tm_tratamientoBE { idTratamiento = 0, tratamiento = "*** Seleccione ***" });

            cbTratamiento.DataSource = listaTratamiento;
            cbTratamiento.DisplayMember = "tratamiento";
            cbTratamiento.ValueMember = "idTratamiento";
            if (listaTratamiento.Count == 2) cbTratamiento.SelectedIndex = 1;
        }
        private void cbTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var idTratamiento = (int)cbTratamiento.SelectedValue;
                BuscarCitaTratamiento(idTratamiento);
            }
            catch { }
        }
        private bool BuscarCitaTratamiento(int idTratamiento)
        {
            var mensajeRetorno = string.Empty;
            var listaTratamientoCita = new tm_tratamientoBL().GetTratamientoCita(idTratamiento, idPaciente, out mensajeRetorno);

            if (listaTratamientoCita.Count > 0)
            {
                MessageBox.Show("El paciente ya tiene citas creadas para este tratamiento.", "Generación de Cita - STPR");
                btnGenerarCita.Enabled = false;
                return false;
            }
            return true;
        }
        private void btnGenerarCita_Click(object sender, EventArgs e)
        {
            var idTratamiento = (int)cbTratamiento.SelectedValue;
            var mensajeRetorno = string.Empty;          
            var mensaje=string.Empty;

            var listaTratamiento = new tm_tratamientoBL().GetTratamiento(idPaciente, idTratamiento, out mensajeRetorno);

            if (!BuscarCitaTratamiento(idTratamiento))return;
            
            else {
                var generaCita = MessageBox.Show("Desea generar la cita para el paciente " + datosPaciente + " ?", "Generación de Cita - STPR ", MessageBoxButtons.YesNo);
                if (generaCita == DialogResult.Yes)
                {
                    var listaCita = new tm_citaBL().SetGenerarCita(idPaciente, listaTratamiento[0].idMedico, listaTratamiento[0].idEspecialidad, tm_usuarioBE.idUsuario, out mensajeRetorno);
                    if (listaCita.Count > 0)
                    {
                        mensaje = "la cita a sido generada de manera satisfactoría";
                        mensaje += Environment.NewLine + "Fecha: " + listaCita[0].fechaCita;
                        mensaje += Environment.NewLine + "Hora: " + listaCita[0].horaCita;
                        mensaje += Environment.NewLine + "Especialidad: " + listaCita[0].Especialidad;
                        mensaje += Environment.NewLine + "Médico: " + listaCita[0].DatosMedico;

                        MessageBox.Show(mensaje, "Generación de Cita - STPR");
                        EnviarNotificacion(listaCita);
                    }
                }
            }            
        }
        private void EnviarNotificacion(List<tm_citaBE> listaCita)
        {
            var mensajeRetorno = string.Empty;
            var titulo = "Confirmación de Cita Médica Automática - STPR";
            var listSTPR = new tm_stprBL().GetStpr(idStpr, out mensajeRetorno);
            var objCuentaEnvio = new tm_cuenta_envioBL().get_cuenta_envio(telefono, out mensajeRetorno);

            var mensajeSMS = new utilitarioBL().GenerarCitaSMS(datosPaciente, listaCita[0].FechaCrea.ToString("dd/MM/yyyy"), listaCita[0].horaCita, listaCita[0].Especialidad, listaCita[0].DatosMedico);
            var mensajeMultimedia = new utilitarioBL().GenerarCitaMultimedia(datosPaciente, listaCita[0].FechaCrea.ToString("dd/MM/yyyy"), listaCita[0].horaCita, listaCita[0].Especialidad, listaCita[0].DatosMedico);
            var mensajeCorreo = new utilitarioBL().GenerarCitaCorreo("Confirmación de Cita Médica Automática - STPR", datosPaciente, listaCita[0].FechaCrea.ToString("dd/MM/yyyy"), listaCita[0].horaCita, listaCita[0].Especialidad, listaCita[0].DatosMedico);

            chkSMS.Visible = listSTPR.sms;
            chkMultimedia.Visible = listSTPR.multimedia;
            chkCorreo.Visible=listSTPR.mail;

            btnCerrarNotificacion.Enabled=false;
            btnGenerarCita.Enabled=false;

            if (listSTPR.sms)
            {
                new utilitarioBL().EnviarSMS(telefono, objCuentaEnvio.telefonoVirtual, objCuentaEnvio.cuentaSID, objCuentaEnvio.token, mensajeSMS, out mensajeRetorno);
                MessageBox.Show("Mensaje de texto enviado de manera satisfactoría", "Notificación STPR");
                chkSMS.Checked = true;
            }
            if (listSTPR.multimedia)
            {
                new utilitarioBL().EnviarMultimedia(datosPaciente, telefono, mensajeMultimedia, out mensajeRetorno);
                MessageBox.Show("Mensaje multimedia enviado de manera satisfactoría", "notificación STPR");
                chkMultimedia.Checked = true;
            }
            if (listSTPR.mail)
            {
                var contenidoCorreo = new utilitarioBL().NotificacionCorreo(datosPaciente, mensajeCorreo);
                new utilitarioBL().EnviarCorreo(datosPaciente, correo, contenidoCorreo, titulo, out mensajeRetorno);
                MessageBox.Show("Correo electrónico enviado de manera satisfactoría", "Notificación STPR");
                chkCorreo.Checked = true;
            }

            btnCerrarNotificacion.Enabled = true;
            btnGenerarCita.Enabled = true;
        }
        private void btnCerrarNotificacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
