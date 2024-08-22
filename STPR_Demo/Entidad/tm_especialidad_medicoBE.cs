using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public class tm_especialidad_medicoBE
    {
        public int idEspecialidadMedico { get; set; }
        public int idEspecialidad { get; set; }
        public int idMedico { get; set; }
        public DateTime fechaCrea { get; set; }
        public int usuarioCrea { get; set; }
        public DateTime? fechaActualiza { get; set; }
        public int? usuarioActualiza { get; set; }
        public string nombreEspecialidad { get; set; }
        public tm_especialidad_medicoBE() { }
        public tm_especialidad_medicoBE(SqlDataReader reader){
            idEspecialidadMedico = Convert.ToInt32(reader["idEspecialidadMedico"]);
            idEspecialidad = Convert.ToInt32(reader["idEspecialidad"]);
            idMedico = Convert.ToInt32(reader["idMedico"]);
            fechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
            usuarioCrea = Convert.ToInt32(reader["usuarioCrea"]);            
            fechaActualiza= reader["fechaActualiza"] != DBNull.Value ? Convert.ToDateTime(reader["fechaActualiza"]) : (DateTime?)null;
            usuarioActualiza = reader["usuarioActualiza"] != DBNull.Value ? Convert.ToInt32(reader["usuarioActualiza"]) : (int?)null;            
            nombreEspecialidad = Convert.ToString(reader["nombre"]);
        }
    }
}
