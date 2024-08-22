using STPR_UI.Entidad;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace STPR_UI.Repositorio
{
    public class tm_cuenta_enviaDA
    {
        public tm_cuenta_envioBE get_cuenta_envio(string telefonoAutenticado, out string mensajeRetorno)
        {
            mensajeRetorno = string.Empty;
            try
            {
                var objCuentaEnvio = new tm_cuenta_envioBE();

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Cuenta_Envio", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@telefonoAutenticado", telefonoAutenticado);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                objCuentaEnvio = new tm_cuenta_envioBE(reader);
                            }

                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return objCuentaEnvio;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
    }
}
