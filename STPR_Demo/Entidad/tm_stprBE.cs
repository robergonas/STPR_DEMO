using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Entidad
{
    public class tm_stprBE
    {
        public int idSTPR { get; set; }
        public int idPaciente { get; set; }
        public int horaDistancia { get; set; }
        public int horaAdicional { get; set; }
        public string horaReferencia { get; set; }
        public bool sms { get; set; }
        public bool multimedia { get; set; }
        public bool mail { get; set; }
        public DateTime fechaCrea { get; set; }
        public int usuarioCrea { get; set; }
        public DateTime? fechaActualiza { get; set; }
        public int? usuarioActualiza { get; set; }
        public tm_stprBE() { }
        public tm_stprBE(SqlDataReader reader)
        {
            idSTPR = Convert.ToInt32(reader["idSTPR"]);
            idPaciente = Convert.ToInt32(reader["idPaciente"]);
            horaDistancia = Convert.ToInt32(reader["horaDistancia"]);
            horaAdicional = Convert.ToInt32(reader["horaAdicional"]);
            horaReferencia = Convert.ToString(reader["horaReferencia"]);
            sms = Convert.ToBoolean(reader["sms"]);
            multimedia = Convert.ToBoolean(reader["multimedia"]);
            mail = Convert.ToBoolean(reader["mail"]);
            fechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
            usuarioCrea = Convert.ToInt32(reader["usuarioCrea"]);
            fechaActualiza = reader["fechaActualiza"] != DBNull.Value ? Convert.ToDateTime(reader["fechaActualiza "]) : (DateTime?)null;
            usuarioActualiza = reader["usuarioActualiza"] != DBNull.Value ? Convert.ToInt32(reader["usuarioActualiza"]) : (int?)null;
        }
    }
}
