using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public static class tm_usuarioBE
    {
        public static int idUsuario { get; set; }
        public static string usuario { get; set; }
        public static string clave { get; set; }
        public static string nombre { get; set; }
        public static string apellidoMaterno { get; set; }
        public static string apellidoPaterno { get; set; }
        public static string correo { get; set; }
        public static string telefono { get; set; }
        public static DateTime fechaCrea { get; set; }
        public static int usuarioCrea { get; set; }
        public static DateTime? fechaActualiza { get; set; }
        public static int? usuarioActualiza { get; set; }
    }
}
