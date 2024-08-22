using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public  class tm_citaBE
    {
        public int IdCita { get; set; }     
        public int IdPaciente { get; set; }
        public string DatosPaciente { get; set; }
        public int IdMedico { get; set; }
        public string DatosMedico { get; set; }
        public int IdEspecialidad { get; set; }
        public string Especialidad { get; set; }
        public int idCalendario { get; set; }
        public DateTime fechaCita { get; set; }
        public string horaCita { get; set; }
        public string Motivo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCrea { get; set; }
        public int UsuarioCrea { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public int? UsuarioActualiza { get; set; }
        public tm_citaBE() { }
        public tm_citaBE(SqlDataReader reader) {
            IdCita = Convert.ToInt32(reader["idCita"].ToString());
            IdPaciente = Convert.ToInt32(reader["idPaciente"].ToString ());
            DatosPaciente = reader["datosPaciente"].ToString();
            IdMedico = Convert.ToInt32(reader["idMedico"].ToString());
            DatosMedico = reader["datosMedico"].ToString();
            IdEspecialidad = Convert.ToInt32(reader["idEspecialidad"].ToString());
            Especialidad = reader["especialidad"].ToString();
            idCalendario = Convert.ToInt32(reader["idCalendario"]);
            fechaCita= Convert.ToDateTime(reader["fechaCita"]);
            horaCita = reader["horaCita"].ToString();
            Motivo = reader["motivo"].ToString();
            Activo = Convert.ToBoolean(reader["activo"]);
            FechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
            UsuarioCrea = Convert.ToInt32(reader["usuarioCrea"]);
            FechaActualiza = reader["FechaActualiza"] != DBNull.Value? Convert.ToDateTime(reader["FechaActualiza"]): (DateTime?)null;
            UsuarioActualiza = reader["UsuarioActualiza"] != DBNull.Value ? Convert.ToInt32(reader["UsuarioActualiza"]):(Int32?)null;
        }
    }
}
