using Microsoft.IdentityModel.Tokens;
using STPR_UI.Entidad;
using STPR_UI.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STPR_UI
{
    public partial class frmAfiliacionSTPR : Form
    {
        public int idPaciente = 0;
        public string telefonoPaciente = string.Empty;
        public string correo = string.Empty;
        public string datosPaciente = string.Empty;

        private frmPacienteConsulta _parentForm;

        public frmAfiliacionSTPR(frmPacienteConsulta parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;

            txtDistancia.KeyPress += new KeyPressEventHandler(TextBoxNumeros_KeyPress);
            txtAdicional.KeyPress += new KeyPressEventHandler(TextBoxNumeros_KeyPress);

            txtDistancia.KeyDown += new KeyEventHandler(Control_KeyDown);
            txtAdicional.KeyDown += new KeyEventHandler(Control_KeyDown);
            txtHoraReferencia.KeyDown += new KeyEventHandler(Control_KeyDown);

            txtHoraReferencia.KeyPress += new KeyPressEventHandler(txtHoraReferencia_KeyPress);
            txtHoraReferencia.Leave += new EventHandler(txtHoraReferencia_Leave);
        }
        //public frmAfiliacionSTPR()
        //{
        //    InitializeComponent();
        //    txtDistancia.KeyPress += new KeyPressEventHandler(TextBoxNumeros_KeyPress);
        //    txtAdicional.KeyPress += new KeyPressEventHandler(TextBoxNumeros_KeyPress);

        //    txtDistancia.KeyDown += new KeyEventHandler(Control_KeyDown);
        //    txtAdicional.KeyDown += new KeyEventHandler(Control_KeyDown);
        //    txtHoraReferencia.KeyDown += new KeyEventHandler(Control_KeyDown);

        //    txtHoraReferencia.KeyPress += new KeyPressEventHandler(txtHoraReferencia_KeyPress);
        //    txtHoraReferencia.Leave += new EventHandler(txtHoraReferencia_Leave);
        //}
        private void txtHoraReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }
        private void txtHoraReferencia_Leave(object sender, EventArgs e)
        {
            ValidateTimeFormat();
        }
        private void ValidateTimeFormat()
        {
            DateTime parsedTime;
            bool isValidTime = DateTime.TryParseExact(
                txtHoraReferencia.Text,
                "HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out parsedTime
            );

            if (!isValidTime)
            {
                MessageBox.Show("Por favor, ingrese una hora válida en formato 24 horas (HH:mm).");
                txtHoraReferencia.Focus();
            }
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
        private void TextBoxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAfiliacion_STPR_Click(object sender, EventArgs e)
        {
            var mensajeRetorno = string.Empty;
            var contenidoSMS = string.Empty;
            var contenidoMultimedia = string.Empty;
            var contenidoCorreo = string.Empty;
            var objSTPR = new tm_stprBE();
            var mensaje = "";
            var error = false;
            var horasAdicional = 0;
            var asunto = "Tu inscripción al Sistema de Telegestión Para Pacientes Rurales ha sido exitosa";            
            try
            {
                if (string.IsNullOrEmpty(txtDistancia.Text))
                {
                    mensaje = "* Ingrese horas de distancia.";
                    error = true;
                }
                if (txtAdicional.Text.Length > 0)
                {
                    horasAdicional = int.Parse(txtAdicional.Text) * 24;
                }
                if (string.IsNullOrEmpty(txtHoraReferencia.Text))
                {
                    if (mensaje.Length > 0) mensaje += "* Ingrese hora referencia.";
                    else mensaje = "* Ingrese hora referencia.";
                    error = true;
                }
                if (!chkSMS.Checked && !chkWSP.Checked && !chkCorreo.Checked)
                {
                    if (mensaje.Length > 0) mensaje += "* Seleccione medio de comunicación";
                    else mensaje = "* Seleccione medio de comunicación";
                    error = true;
                }
                if (error)
                {
                    MessageBox.Show(mensaje, "Se encontrarón las siguientes incidencias");
                    return;
                }

                var confirma = MessageBox.Show("Esta seguro de continuar con la afiliación del paciente " + lblDatosPaciente.Text, "Afiliación STPR", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == confirma)
                {
                    objSTPR.idPaciente = idPaciente;
                    objSTPR.horaReferencia = txtHoraReferencia.Text;
                    objSTPR.multimedia = chkWSP.Checked;
                    objSTPR.sms = chkSMS.Checked;
                    objSTPR.mail = chkCorreo.Checked;
                    objSTPR.horaDistancia = int.Parse(txtDistancia.Text);
                    objSTPR.horaAdicional = horasAdicional;
                    objSTPR.usuarioCrea = tm_usuarioBE.idUsuario;

                    var objCuentaEnvio = new tm_cuenta_envioBL().get_cuenta_envio(telefonoPaciente, out mensajeRetorno);
                    if (objCuentaEnvio is null)
                    {
                        MessageBox.Show("No se puede realizar el proceso de afiliación porque el número de teléfono no esta autenticado", "Afiliación STPR");
                        return;
                    }
                    var resultado = new tm_stprBL().set_stpr_ins(objSTPR, out mensajeRetorno);
                    if (resultado)
                    {
                        MessageBox.Show("Proceso de afiliación del paciente se realizo de manera satisfactoría, se procedió a enviar mensaje de bienvenida");                        

                        if (chkSMS.Checked)
                        {
                            contenidoSMS = new utilitarioBL().ContenidoSMS(datosPaciente);
                            new utilitarioBL().EnviarSMS(telefonoPaciente, objCuentaEnvio.telefonoVirtual, objCuentaEnvio.cuentaSID, objCuentaEnvio.token, contenidoSMS, out mensajeRetorno);
                            MessageBox.Show("Mensaje de texto enviado de manera satisfactoría", "Afiliación STPR");
                        }
                        if (chkWSP.Checked)
                        {
                            contenidoMultimedia = new utilitarioBL().ContenidoMultimedia(datosPaciente);
                            new utilitarioBL().EnviarMultimedia(datosPaciente,telefonoPaciente, contenidoMultimedia, out mensajeRetorno);
                            MessageBox.Show("Mensaje multimedia enviado de manera satisfactoría", "Afiliación STPR");
                        }
                        if (chkCorreo.Checked)
                        {
                            contenidoCorreo = new utilitarioBL().ContenidoCorreo(datosPaciente);
                            new utilitarioBL().EnviarCorreo(datosPaciente,correo, contenidoCorreo, asunto, out mensajeRetorno);
                            MessageBox.Show("Correo electrónico enviado de manera satisfactoría", "Afiliación STPR");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Afiliación STPR");
            }
        }
        private void frmAfiliacionSTPR_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.BuscarPaciente();
        }
    }
}