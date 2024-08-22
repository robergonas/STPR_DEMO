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
        public  void get_usuario(string usuario, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                using (SqlConnection conn= new SqlConnection(ConfigurationManager.AppSettings["StrConn"])){
                    using (SqlCommand cmd = new SqlCommand("get_usuario", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        conn.Open();

                        using (SqlDataReader reader=cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                tm_usuarioBE.idUsuario = Convert.ToInt32(reader["idUsuario"]);
                                tm_usuarioBE.usuario = Convert.ToString(reader["usuario"]);
                                tm_usuarioBE.clave = Convert.ToString(reader["clave"]);
                                tm_usuarioBE.nombre = Convert.ToString(reader["nombre"]);
                                tm_usuarioBE.apellidoMaterno = Convert.ToString(reader["apellidoMaterno"]);
                                tm_usuarioBE.apellidoPaterno = Convert.ToString(reader["apellidoPaterno"]);
                                tm_usuarioBE.correo = Convert.ToString(reader["correo"]);
                                tm_usuarioBE.telefono = Convert.ToString(reader["telefono"]);
                                tm_usuarioBE.fechaCrea = Convert.ToDateTime(reader["fechaCrea"]);
                                tm_usuarioBE.usuarioCrea = Convert.ToInt32(reader["usuarioCrea"]);
                                DateTime? fecAct = reader["fechaActualiza"] as DateTime?;
                                int? usAct = reader["usuarioActualiza"] as Int32?;

                                tm_usuarioBE.fechaActualiza = fecAct;
                                tm_usuarioBE.usuarioActualiza = usAct;
                            }
                        }
                    }
                } 

            mensajeRetorno= "Ok|Proceso realizado de manera satisfactoria";
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
            }
        }
    }
}
