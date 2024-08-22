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
    public  class tm_especialidad_medicoDA
    {
        public List<tm_especialidad_medicoBE> GetEspecialidadMedico(int idMedico, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var listaEspecialidad= new List<tm_especialidad_medicoBE>();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Especialidad_Medico", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);                        

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var objEspecialidad = new tm_especialidad_medicoBE(reader);
                                listaEspecialidad.Add(objEspecialidad);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return listaEspecialidad;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
    }
}
