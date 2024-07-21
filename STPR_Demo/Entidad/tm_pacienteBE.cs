using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public class tm_pacienteBE
    {
        public int idPaciente { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string numeroDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool masculino { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaCrea { get; set; }
        public int usuarioCrea { get; set; }
        public DateTime? fechaActualiza { get; set; }
        public int? usuarioActualiza { get; set; }

        public tm_pacienteBE() { }
        public tm_pacienteBE(SqlDataReader reader) {
            idPaciente = Convert.ToInt32(reader["idPaciente"]);
            nombre = Convert.ToString(reader["nombre"]);
            apellidoPaterno = Convert.ToString(reader["apellidoPaterno"]);
            apellidoMaterno = Convert.ToString(reader["apellidoMaterno"]);
            numeroDocumento = Convert.ToString(reader["numeroDocumento"]);
            fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
            masculino = Convert.ToBoolean(reader["masculino"]);
            direccion = Convert.ToString(reader["direccion"]);
            telefono = Convert.ToString(reader["telefono"]);
            correo = Convert.ToString(reader["correo"]);
            fechaRegistro = Convert.ToDateTime(reader["fechaRegistro"]);
            fechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
            usuarioCrea = Convert.ToInt32(reader["usuarioCrea"]);
            DateTime? fecAct = reader["fechaActualiza"] as DateTime?;
            int? usAct = reader["usuarioActualiza"] as Int32?;

            fechaActualiza = fecAct;
            usuarioActualiza = usAct;
        }
    }
}
