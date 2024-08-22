using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Parameters;
using STPR_UI.Entidad;
using STPR_UI.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace STPR_UI
{
    public partial class frmPacienteConsulta : Form
    {
        private string datosPaciente = string.Empty;
        private int idPaciente = 0;
        private string telefono = string.Empty;
        private string correo = string.Empty;
        private int idstpr = 0;
        private bool enviarSMS = false;
        private bool enviarMultimedia = false;
        private bool enviarCorreo = false;

        private ContextMenuStrip contextMenuStrip;
        public frmPacienteConsulta()
        {
            InitializeComponent();

            txtDNI.KeyDown += new KeyEventHandler(Control_KeyDown);
            txtNombre.KeyDown += new KeyEventHandler(Control_KeyDown);
            txtApellidos.KeyDown += new KeyEventHandler(Control_KeyDown);

            txtDNI.TextChanged += new EventHandler(TextBoxBuscar_TextChanged);
            txtNombre.TextChanged += new EventHandler(TextBoxBuscar_TextChanged);
            txtApellidos.TextChanged += new EventHandler(TextBoxBuscar_TextChanged);

            dtgvPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPaciente.MultiSelect = false;
            dtgvPaciente.ScrollBars = ScrollBars.Both;

            dtgvPaciente.SelectionChanged += new EventHandler(dtgvPaciente_SelectionChanged);

            dtgvPaciente.AutoGenerateColumns = false;
            dtgvPaciente.CellDoubleClick += dtgvPaciente_CellDoubleClick;


            DataGridpaciente();

            dtgvPaciente.DataSource = null;
            dtgvPaciente.Visible = false;

            txtDNI.Focus();
        }
        private void dtgvPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvPaciente.Rows[e.RowIndex];

                int idstpr = Convert.ToInt32(row.Cells["idstpr"].Value);
                if (idstpr > 0)
                {
                    MessageBox.Show("Este paciente ya se encuentra afiliado a STPR", "Afiliación STPR");
                    return;
                }
                afiliarToolStripMenuItem_Click(sender, e);
            }
        }
        private void dtgvPaciente_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvPaciente.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvPaciente.SelectedRows[0];
                tm_pacienteBE selectedPaciente = (tm_pacienteBE)selectedRow.DataBoundItem;

                datosPaciente = selectedPaciente.nombre + " " + selectedPaciente.apellidoPaterno + " " + selectedPaciente.apellidoMaterno;
                telefono = selectedPaciente.telefono;
                correo = selectedPaciente.correo;
                lblDatosPaciente.Text = datosPaciente;
                idPaciente = selectedPaciente.idPaciente;
                idstpr = int.Parse(selectedPaciente.idstpr.ToString());
            }
        }
        private void DataGridpaciente()
        {
            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idPaciente",
                HeaderText = "Código Paciente",
                DataPropertyName = "idPaciente",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "numeroDocumento",
                HeaderText = "Documento",
                DataPropertyName = "numeroDocumento",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "nombre",
                HeaderText = "Nombre",
                DataPropertyName = "nombre",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "apellidoPaterno",
                HeaderText = "Ap. Paterno",
                DataPropertyName = "apellidoPaterno",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "apellidoMaterno",
                HeaderText = "Ap. Materno",
                DataPropertyName = "apellidoMaterno",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "fechaRegistro",
                HeaderText = "Fecha Registro",
                DataPropertyName = "fechaRegistro",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "telefono",
                HeaderText = "Teléfono",
                DataPropertyName = "telefono",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "correo",
                HeaderText = "Correo",
                DataPropertyName = "correo",
                ReadOnly = true
            });

            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "direccion",
                HeaderText = "Dirección",
                DataPropertyName = "direccion",
                ReadOnly = true
            });
            dtgvPaciente.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idstpr",
                HeaderText = "idstpr",
                DataPropertyName = "idstpr",
                ReadOnly = true,
                Visible = false
            });

            contextMenuStrip = new ContextMenuStrip();
            dtgvPaciente.CellMouseDown += new DataGridViewCellMouseEventHandler(dtgvPaciente_CellMousedown);
            contextMenuStrip.Items.Add("Afiliar Paciente", null, afiliarToolStripMenuItem_Click);
            contextMenuStrip.Items.Add("Notificar Paciente", null, notificarToolStripMenuItem_Click);
            contextMenuStrip.Items.Add("Asignar Tratamiento", null, tratamientoToolStripMenuItem_Click);
            contextMenuStrip.Items.Add("Generar Cita", null, generarCitaToolStripMenuItem_Click);

            dtgvPaciente.ContextMenuStrip = contextMenuStrip;
        }
        private void afiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idstpr > 0)
            {
                MessageBox.Show("Este paciente ya se encuentra afiliado a STPR", "Afiliación STPR");
                return;
            }

            var confirma = MessageBox.Show("Esta seguro de afiliar a: " + datosPaciente + " al Sistema de Telegestión Para Pacientes Rurales", "Afiliación STPR", MessageBoxButtons.YesNo);

            if (confirma == DialogResult.Yes)
            {
                var frm = new frmAfiliacionSTPR(this);
                frm.lblDatosPaciente.Text = datosPaciente;
                frm.datosPaciente = datosPaciente;
                frm.idPaciente = idPaciente;
                frm.telefonoPaciente = telefono;
                frm.correo = correo;
                frm.ShowDialog();
            }
        }
        private void notificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mensajeRetorno = string.Empty;
            if (dtgvPaciente.SelectedRows.Count > 0)
            {
                if (!CargarTratamiento())
                {
                    gbNotificacion.Visible = false;
                    return;
                }

                gbNotificacion.Visible = true;
                var row = dtgvPaciente.SelectedRows[0];
                idstpr = int.Parse(row.Cells["idstpr"].Value.ToString());
                idPaciente = int.Parse(row.Cells["idPaciente"].Value.ToString());
                correo = row.Cells["correo"].Value.ToString();
                datosPaciente = row.Cells["nombre"].Value.ToString() + " " + row.Cells["apellidoPaterno"].Value.ToString() + " " + row.Cells["apellidoMaterno"].Value.ToString();
                telefono = row.Cells["telefono"].Value.ToString();

                var objStpr = new tm_stprBL().GetStpr(idstpr, out mensajeRetorno);
                enviarSMS = objStpr.sms;
                enviarMultimedia = objStpr.multimedia;
                enviarCorreo = objStpr.mail;

                chkSMS.Visible = objStpr.sms;
                chkMultimedia.Visible = objStpr.multimedia;
                chkCorreo.Visible = objStpr.mail;

                if (idstpr == 0)
                {
                    MessageBox.Show("El paciente aún no esta afiliado.", "Notificacion STPR");
                    return;
                }

                //gbNotificacion.Visible = true;
                lblDatosPacienteNotificacion.Text = datosPaciente + " Teléf: " + telefono + " Correo: " + correo;

                btnCerrar.Enabled = false;
            }
        }
        private bool CargarTratamiento()
        {
            var mensajeRetorno = string.Empty;
            List<tm_tratamientoBE> listaTratamiento = new tm_tratamientoBL().GetTratamiento(idPaciente, 0, out mensajeRetorno);
            if (listaTratamiento.Count == 0)
            {
                MessageBox.Show("El paciente no tiene tratamiento activo.", "Notifacación - STPR");
                gbNotificacion.Visible = false;
                return false;
            }

            listaTratamiento.Insert(0, new tm_tratamientoBE { idTratamiento = 0, tratamiento = "*** Seleccione ***" });

            cbTratamiento.DataSource = listaTratamiento;
            cbTratamiento.DisplayMember = "tratamiento";
            cbTratamiento.ValueMember = "idTratamiento";

            if (listaTratamiento.Count == 2)
            {
                cbTratamiento.SelectedIndex = 1;
                BuscarCita();
            }
            else cbTratamiento.SelectedIndex = 0;

            return true;
        }
        private void BuscarCita()
        {
            try
            {
                var objUtil = new utilitarioBL();
                var mensajeRetorno = string.Empty;
                var idTratamiento = (int)cbTratamiento.SelectedValue;
                var listaTratamiento = new tm_tratamientoBL().GetTratamiento(idPaciente, idTratamiento, out mensajeRetorno);
                var idEspecialidad = listaTratamiento[0].idEspecialidad;
                var idMedico = listaTratamiento[0].idMedico;
                var listaCita = new tm_citaBL().GetCita(idPaciente, 0, idEspecialidad, out mensajeRetorno);
                var mensaje = string.Empty;
                var tipo = 0;
                var titulo = string.Empty;

                if (listaCita.Count == 0 || listaCita is null)
                {
                    var crearCita = MessageBox.Show("El paciente no tiene cita en este tratamiento, desea generar una?", "Generar cita - STPR", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == crearCita)
                    {
                        listaCita = new tm_citaBL().SetGenerarCita(idPaciente, idMedico, idEspecialidad, tm_usuarioBE.idUsuario, out mensajeRetorno);
                        if (listaCita.Count > 0)
                        {
                            mensaje = "la cita a sido generada de manera satisfactoría";
                            mensaje += Environment.NewLine + "Fecha: " + listaCita[0].fechaCita;
                            mensaje += Environment.NewLine + "Hora: " + listaCita[0].horaCita;
                            mensaje += Environment.NewLine + "Especialidad: " + listaCita[0].Especialidad;
                            mensaje += Environment.NewLine + "Médico: " + listaCita[0].DatosMedico;

                            MessageBox.Show(mensaje, "Generación de cita - STPR");

                            mensaje = new utilitarioBL().GenerarCitaSMS(datosPaciente, listaCita[0].FechaCrea.ToString("dd/MM/yyyy"), listaCita[0].horaCita, listaCita[0].Especialidad, listaCita[0].DatosMedico);
                            tipo = 1;
                            EnviarNotificacion(mensaje, titulo, tipo);

                            mensaje = new utilitarioBL().GenerarCitaMultimedia(datosPaciente, listaCita[0].FechaCrea.ToString("dd/MM/yyyy"), listaCita[0].horaCita, listaCita[0].Especialidad, listaCita[0].DatosMedico);
                            tipo = 2;
                            EnviarNotificacion(mensaje, titulo, tipo);

                            titulo = "Confirmación de Cita Médica Automática - STPR";
                            mensaje = new utilitarioBL().GenerarCitaCorreo(titulo, datosPaciente, listaCita[0].FechaCrea.ToString("dd/MM/yyyy"), listaCita[0].horaCita, listaCita[0].Especialidad, listaCita[0].DatosMedico);
                            tipo = 3;
                            EnviarNotificacion(mensaje, titulo, tipo);
                        }
                    }
                }
                txtNotificacion.Text = new utilitarioBL().MensajeNotificacion(datosPaciente, listaCita[0].FechaCrea.ToString("dd/MM/yyyy"), listaCita[0].horaCita, listaCita[0].Especialidad, listaCita[0].DatosMedico);

                chkSMS.Checked = false;
                chkMultimedia.Checked = false;
                chkCorreo.Checked = false;
            }
            catch { }
        }
        private void generarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mensajeRetorno=string.Empty;
            if (idstpr == 0)
            {
                MessageBox.Show("El paciente no esta afiliado al programa STPR.", "Generación der Citas - STPR");
                return;
            }

            List<tm_tratamientoBE> listaTratamiento = new tm_tratamientoBL().GetTratamiento(idPaciente, 0, out mensajeRetorno);
            if (listaTratamiento.Count == 0)
            {
                MessageBox.Show("El paciente no tiene tratamiento activo.", "Generación de Cita - STPR");                
            }
            else {
                var frm = new frmGenerarCita(listaTratamiento);
                frm.idPaciente = idPaciente;
                frm.idStpr = idstpr;
                frm.correo = correo;
                frm.datosPaciente = datosPaciente;
                frm.telefono = telefono;
                frm.ShowDialog();
            }            
        }
        private void tratamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTratamiento();
            frm.idPaciente = idPaciente;
            frm.lblDatosPaciente.Text = datosPaciente;
            frm.ShowDialog();
        }
        private void dtgvPaciente_CellMousedown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dtgvPaciente.ClearSelection();
                dtgvPaciente.Rows[e.RowIndex].Selected = true;
                dtgvPaciente.CurrentCell = dtgvPaciente.Rows[e.RowIndex].Cells[0];
            }
        }
        private void InitializeContextMenuStrip()
        {
            contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem afiliarMenuItem = new ToolStripMenuItem("Afiliar Paciente", null, afiliarToolStripMenuItem_Click);
            ToolStripMenuItem notificarMenuItem = new ToolStripMenuItem("Notificar Paciente", null, notificarToolStripMenuItem_Click);
            ToolStripMenuItem tratamientoMenuItem = new ToolStripMenuItem("Asignar Tratamiento", null, tratamientoToolStripMenuItem_Click);
            ToolStripMenuItem generarCitaMenuItem = new ToolStripMenuItem("Generar Cita", null, generarCitaToolStripMenuItem_Click);

            contextMenuStrip.Items.AddRange(new ToolStripMenuItem[] { notificarMenuItem, tratamientoMenuItem });
        }
        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length > 0 || txtNombre.Text.Length > 0 || txtApellidos.Text.Length > 0)
            {
                BuscarPaciente();
            }
            else dtgvPaciente.DataSource = null;
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
        public void BuscarPaciente()
        {
            if (!dtgvPaciente.Visible) dtgvPaciente.Visible = true;

            var mensajeRetorno = string.Empty;
            var listaPaciente = new tm_pacienteBL().get_paciente(0, txtDNI.Text, txtNombre.Text, txtApellidos.Text, out mensajeRetorno);

            dtgvPaciente.DataSource = listaPaciente;
            dtgvPaciente.Refresh();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dtgvPaciente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dtgvPaciente.Rows)
            {
                var idstpr = int.Parse(row.Cells["idstpr"].Value?.ToString());

                if (idstpr > 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.SeaGreen;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
            }
        }
        private void dtgvPaciente_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtgvPaciente.ClearSelection();
                dtgvPaciente.Rows[e.RowIndex].Selected = true;
                dtgvPaciente.CurrentCell = dtgvPaciente.Rows[e.RowIndex].Cells[0];
            }
        }
        private void btnCerrarNotificacion_Click(object sender, EventArgs e)
        {
            btnCerrar.Enabled = true;
            gbNotificacion.Visible = false;
        }
        private void btnNotificacion_Click(object sender, EventArgs e)
        {

            btnCerrarNotificacion.Enabled = false;
            btnNotificacion.Enabled = false;

            var mensaje = txtNotificacion.Text;
            var titulo = "Instrucciones Importantes Antes de su Cita Médica";
            var tipo = 1;
            EnviarNotificacion(mensaje, titulo, tipo);

            mensaje = txtNotificacion.Text;
            titulo = "";
            tipo = 2;
            EnviarNotificacion(mensaje, titulo, tipo);

            var MensajeNotificacionCorreo = new utilitarioBL().MensajeNotificacionCorreo(datosPaciente, titulo, txtNotificacion.Text);
            mensaje = new utilitarioBL().NotificacionCorreo(datosPaciente, MensajeNotificacionCorreo);
            titulo = "";
            tipo = 3;
            EnviarNotificacion(mensaje, titulo, tipo);

            btnCerrarNotificacion.Enabled = true;
            btnNotificacion.Enabled = true;
        }
        private void EnviarNotificacion(string mensaje, string titulo, int tipo)
        {
            var mensajeRetorno = string.Empty;
            var objCuentaEnvio = new tm_cuenta_envioBL().get_cuenta_envio(telefono, out mensajeRetorno);

            if (enviarSMS)
            {
                if (tipo == 1)
                {
                    new utilitarioBL().EnviarSMS(telefono, objCuentaEnvio.telefonoVirtual, objCuentaEnvio.cuentaSID, objCuentaEnvio.token, mensaje, out mensajeRetorno);
                    MessageBox.Show("Mensaje de texto enviado de manera satisfactoría", "Notificación STPR");
                    chkSMS.Checked = true;
                }
            }
            if (enviarMultimedia)
            {
                if (tipo == 2)
                {
                    new utilitarioBL().EnviarMultimedia(datosPaciente, telefono, mensaje, out mensajeRetorno);
                    MessageBox.Show("Mensaje multimedia enviado de manera satisfactoría", "notificación STPR");
                    chkMultimedia.Checked = true;
                }
            }
            if (enviarCorreo)
            {
                if (tipo == 3)
                {
                    var contenidoCorreo = new utilitarioBL().NotificacionCorreo(datosPaciente, mensaje);
                    new utilitarioBL().EnviarCorreo(datosPaciente, correo, contenidoCorreo, titulo, out mensajeRetorno);
                    MessageBox.Show("Correo electrónico enviado de manera satisfactoría", "Notificación STPR");
                    chkCorreo.Checked = true;
                }
            }
        }
        private void frmPacienteConsulta_Load(object sender, EventArgs e)
        {
            gbNotificacion.Visible = false;
        }
        private void cbTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCita();
        }
    }
}
