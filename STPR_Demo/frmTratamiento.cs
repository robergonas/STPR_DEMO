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

namespace STPR_UI
{
    public partial class frmTratamiento : Form
    {
        public int idPaciente;
        public frmTratamiento()
        {
            InitializeComponent();
            cbEspecialidad.Enabled = false;
            CargarMedico();
        }
        private void CargarMedico()
        {
            var mensajeRetorno = string.Empty;
            List<tm_medicoBE>listaMedico = new tm_medicoBL().GetMedico(0, string.Empty, out mensajeRetorno);
            listaMedico.Insert(0, new Entidad.tm_medicoBE { idMedico = 0, NombreCompleto = "*** Seleccione ***" });

            cbMedico.DataSource = listaMedico;
            cbMedico.DisplayMember = "NombreCompleto";
            cbMedico.ValueMember = "idMedico";
            cbMedico.SelectedIndex = 0;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var mensajeRetorno = string.Empty;
                var idMedico = (int)cbMedico.SelectedValue;
                List<tm_especialidad_medicoBE> listaEspecialidad = new tm_especialidad_medicoBL().GetEspecialidadMedico(idMedico, out mensajeRetorno);
                listaEspecialidad.Insert(0, new Entidad.tm_especialidad_medicoBE { idEspecialidad = 0, nombreEspecialidad = "*** Seleccione ***" });

                cbEspecialidad.DataSource = listaEspecialidad;
                cbEspecialidad.DisplayMember = "nombreEspecialidad";
                cbEspecialidad.ValueMember = "idEspecialidad";

                if (listaEspecialidad.Count == 2)
                {
                    cbEspecialidad.SelectedIndex = 1;
                    cbEspecialidad.Enabled = false;
                }
                else
                {
                    cbEspecialidad.SelectedIndex = 0;
                    cbEspecialidad.Enabled = true;
                }
            }
            catch (Exception ex)
            {
            }            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var error = false;
            var mensaje=string.Empty;
            var mensajeRetorno=string.Empty;

            if ((int)cbMedico.SelectedValue==0){
                error = true;
                mensaje += Environment.NewLine + "Seleccione médico.";
            }
            if (cbEspecialidad.SelectedValue == null) {
                error = true;
                mensaje += Environment.NewLine + "No se tiene datos de la especialidad.";
            }
            if (DateTime.Today > dtFechaInicia.Value.Date) { 
                error = true;
                mensaje += Environment.NewLine + "La fecha de inicio del tratamiento no puede ser menor que el dia hoy.";
            }
            if (string.IsNullOrEmpty(txtDiagnostico.Text)) { 
                error = true;
                mensaje += Environment.NewLine + "Ingrese el diagnostico del paciente.";
            }

            if (error) {
                MessageBox.Show(mensaje,"Asignar Tratamiento");
                return;
            }

            var objTratamiento= new tm_tratamientoBE();
            objTratamiento.idMedico=(int)cbMedico.SelectedValue;
            objTratamiento.idEspecialidad=(int)cbEspecialidad.SelectedValue;
            objTratamiento.idPaciente = idPaciente;
            objTratamiento.fechaInicio=dtFechaInicia.Value.Date;
            objTratamiento.diagnostico=txtDiagnostico.Text;
            objTratamiento.medicacion=txtMedicacion.Text;
            objTratamiento.reacciones=txtReaccion.Text;
            objTratamiento.notas=txtNota.Text;
            objTratamiento.usuarioCrea= tm_usuarioBE.idUsuario;

            var resTratamiento = new tm_tratamientoBL().SetTratamientoIns(objTratamiento, out mensajeRetorno);

            if (resTratamiento) MessageBox.Show("Tratamiento guardado de manera satisfactría.");
            else MessageBox.Show("Error al guardar el tratamiento.");
        }
    }
}
