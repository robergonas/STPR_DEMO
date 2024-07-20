using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public class tm_usuarioBE
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string apellidoMaterno { get; set; }
        public string apellidoPaterno { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public DateTime fechaCrea { get; set; }
        public int usuarioCrea { get; set; }
        public DateTime? fechaActualiza { get; set; }
        public int? usuarioActualiza { get; set; }

        public tm_usuarioBE() { }
        public tm_usuarioBE(SqlDataReader reader)
        {
            idUsuario = Convert.ToInt32(reader["idUsuario"]);
            usuario = Convert.ToString(reader["usuario"]);
            clave = Convert.ToString(reader["clave"]);
            nombre = Convert.ToString(reader["nombre"]);
            apellidoMaterno = Convert.ToString(reader["apellidoMaterno"]);
            apellidoPaterno = Convert.ToString(reader["apellidoPaterno"]);
            correo = Convert.ToString(reader["correo"]);
            telefono = Convert.ToString(reader["telefono"]);
            fechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
            usuarioCrea = Convert.ToInt32(reader["usuarioCrea"]);            
            DateTime? fecAct = reader["fechaActualiza"] as DateTime?;
            int? usAct= reader["usuarioActualiza"] as Int32?;

            fechaActualiza = fecAct;
            usuarioActualiza = usAct;
        }
    }
}
