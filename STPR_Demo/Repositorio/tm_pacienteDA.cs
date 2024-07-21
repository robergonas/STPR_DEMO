using STPR_UI.Entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Repositorio
{
    public class tm_pacienteDA
    {
        public List<tm_pacienteBE> get_paciente(int idPaciente,  string numeroDocumento,string nombre,string apellidos, out string mensajeRetorno)
        {
            mensajeRetorno = string.Empty;
            try
            {
                var listaPaciente = new List<tm_pacienteBE>();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Paciente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellidos", apellidos);

                        conn.Open();
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                var objPaciente = new tm_pacienteBE(reader);
                                listaPaciente.Add(objPaciente);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return listaPaciente;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
    }
}
