using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public class tm_tratamientoBE
    {
        public int idTratamiento { get; set; }
        public string tratamiento { get; set; }
        public int idPaciente { get; set; }
        public string paciente { get; set; }
        public int idMedico { get; set; }
        public string medico { get; set; }
        public int idEspecialidad { get; set; }
        public string especialidad { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public bool activo { get; set; }
        public string diagnostico { get; set; }
        public string medicacion { get; set; }
        public string notas { get; set; }
        public string reacciones { get; set; }
        public DateTime fechaCrea { get; set; }
        public int usuarioCrea { get; set; }
        public tm_tratamientoBE() { }
        public tm_tratamientoBE(SqlDataReader reader) {
            idTratamiento = Convert.ToInt32(reader["idTratamiento"]);
            tratamiento = reader["tratamiento"].ToString();
            idPaciente = Convert.ToInt32(reader["idPaciente"]);
            paciente = reader["paciente"].ToString();
            idMedico = Convert.ToInt32(reader["idMedico"]);
            medico = reader["Medico"].ToString();
            idEspecialidad = Convert.ToInt32(reader["idEspecialidad"]);
            especialidad = reader["especialidad"].ToString();
            fechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
            fechaFin = reader["fechaFin"] != DBNull.Value ? Convert.ToDateTime(reader["fechaFin"]) : (DateTime?)null;
            activo = Convert.ToBoolean(reader["activo"]);
            diagnostico = reader["diagnostico"].ToString();
            medicacion = reader["medicacion"].ToString();
            notas = reader["notas"].ToString();
            reacciones = reader["reacciones"].ToString();
            fechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
            usuarioCrea = Convert.ToInt32(reader["usuarioCrea"].ToString());
        }
    }
    public class TratamientiCitaBE {
        public int idTratamiento { get; set; }
        public int idCita { get; set; }
        public int idCalendario { get; set; }
        public int idMedico { get; set; }
        public int idPaciente { get; set; }
        public TratamientiCitaBE() { }
        public TratamientiCitaBE(SqlDataReader reader) {
            idTratamiento = Convert.ToInt32(reader["idTratamiento"]);
            idCita = Convert.ToInt32(reader["idCita"]);
            idCalendario = Convert.ToInt32(reader["idCalendario"]);
            idMedico = Convert.ToInt32(reader["idMedico"]);
            idPaciente = Convert.ToInt32(reader["idPaciente"]);
        }
    }
}
