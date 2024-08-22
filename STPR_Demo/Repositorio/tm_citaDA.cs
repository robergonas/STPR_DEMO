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
    public class tm_citaDA
    {
        public List<tm_citaBE> SetGenerarCita(int idPaciente, int idMedico, int idEspecialidad, int usuCrea, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var listaCita = new List<tm_citaBE>();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Set_Generar_Cita", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
                        cmd.Parameters.AddWithValue("@usuCrea", usuCrea);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var objCita = new tm_citaBE(reader);
                                listaCita.Add(objCita);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return listaCita;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
        public List<tm_citaBE> GetCita(int idPaciente, int idMedico, int idEspecialidad, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var listaCita= new List<tm_citaBE>();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Cita", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var objCita = new tm_citaBE(reader);
                                listaCita.Add(objCita);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return listaCita;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
    }
}
