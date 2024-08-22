using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public class tm_cuenta_envioBE
    {
        public int idCuenta { get; set; }
        public string cuentaSID { get; set; }
        public string token { get; set; }
        public string telefonoVirtual { get; set; }
        public string telefonoAutenticado { get; set; }
        public int usuarioCrea { get; set; }
        public DateTime fechaCrea { get; set; }
        public int? usuarioModifica { get; set; }
        public DateTime? fechaModifica { get; set; }
        public tm_cuenta_envioBE() { }
        public tm_cuenta_envioBE(SqlDataReader reader) {
            idCuenta = Convert.ToInt32(reader["idCuenta"]);
            cuentaSID = Convert.ToString(reader["cuentaSID"]);
            token = Convert.ToString(reader["token"]);
            telefonoVirtual = Convert.ToString(reader["telefonoVirtual"]);
            telefonoAutenticado = Convert.ToString(reader["telefonoAutenticado"]);
            fechaModifica = reader["fechaModifica"] != DBNull.Value ? Convert.ToDateTime(reader["fechaModifica "]) : (DateTime?)null;
            usuarioModifica = reader["usuarioModifica"] != DBNull.Value ? Convert.ToInt32(reader["usuarioModifica"]) : (int?)null;
        }
    }
}
