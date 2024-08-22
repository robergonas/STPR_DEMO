using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public class tm_medicoBE
    {
        public int idMedico { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fechaCrea { get; set; }
        public int usuarioCrea { get; set; }
        public DateTime? fechaActualiza { get; set; }
        public int? usuarioActualiza { get; set; }
        public string NombreCompleto { get; set; }
        public tm_medicoBE() { }
        public tm_medicoBE(SqlDataReader reader)
        {
            idMedico = Convert.ToInt32(reader["idMedico"]);
            nombre = Convert.ToString(reader["nombre"]);
            apellidoPaterno = Convert.ToString(reader["apellidoPaterno"]);
            apellidoMaterno = Convert.ToString(reader["apellidoMaterno"]);
            direccion = Convert.ToString(reader["direccion"]);
            telefono = Convert.ToString(reader["telefono"]);
            fechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
            usuarioCrea = Convert.ToInt32(reader["usuarioCrea"]);
            fechaActualiza = reader["fechaActualiza"] != DBNull.Value ? Convert.ToDateTime(reader["fechaActualiza "]) : (DateTime?)null;
            usuarioActualiza = reader["usuarioActualiza"] != DBNull.Value ? Convert.ToInt32(reader["usuarioActualiza"]) : (int?)null;
            NombreCompleto = $"{nombre} {apellidoPaterno} {apellidoMaterno}";
        }
    }
}
