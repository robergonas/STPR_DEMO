using STPR_UI.Entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace STPR_UI.Repositorio
{
    public  class tm_medicoDA
    {
        public List<tm_medicoBE> GetMedico(int idMedico, string datosMedico, out string mensajeRetorno ) {
            mensajeRetorno = string.Empty;
            try
            {
                var listaMedico= new List<tm_medicoBE>();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Medico", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@datosMedico", datosMedico);                        

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var objMedico= new tm_medicoBE(reader);
                                listaMedico.Add(objMedico);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return listaMedico;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
    }
}
