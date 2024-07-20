using STPR_UI.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace STPR_UI.Repositorio
{
    public class tm_usuarioDA
    {
        public  tm_usuarioBE get_usuario(string usuario, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var objUsuario = new tm_usuarioBE();
                using (SqlConnection conn= new SqlConnection(ConfigurationManager.AppSettings["StrConn"])){
                    using (SqlCommand cmd = new SqlCommand("get_usuario", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        conn.Open();

                        using (SqlDataReader reader=cmd.ExecuteReader()) {
                            if (reader.Read()) { 
                                objUsuario= new tm_usuarioBE(reader);
                            }
                        }
                    }
                } 

            mensajeRetorno= "Ok|Proceso realizado de manera satisfactoria";
                return objUsuario;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
    }
}
