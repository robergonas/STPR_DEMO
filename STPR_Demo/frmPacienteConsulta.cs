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

namespace STPR_UI
{
    public partial class frmPacienteConsulta : Form
    {
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

            dtgvPaciente.AutoGenerateColumns = false;

            DataGridpacinete();

            dtgvPaciente.DataSource = null;

            txtDNI.Focus();
        }
        private void DataGridpacinete()
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
        private void BuscarPaciente()
        {
            var mensajeRetorno = string.Empty;
            var listaPaciente = new tm_pacienteBL().get_paciente(0, txtDNI.Text, txtNombre.Text, txtApellidos.Text, out mensajeRetorno);

            dtgvPaciente.DataSource = listaPaciente;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
