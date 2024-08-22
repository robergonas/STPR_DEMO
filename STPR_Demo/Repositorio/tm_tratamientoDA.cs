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
using System.Drawing;

namespace STPR_UI.Repositorio
{
    public class tm_tratamientoDA
    {
        public List<TratamientiCitaBE> GetTratamientoCita(int idTratamiento,int idPaciente, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var listaTratamientoCita = new List<TratamientiCitaBE>();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Tratamiento_Cita", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idTratamiento", idTratamiento);
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);                        

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var objTratamientoCita = new TratamientiCitaBE(reader);
                                listaTratamientoCita.Add(objTratamientoCita);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return listaTratamientoCita;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
        public List<tm_tratamientoBE> GetTratamiento(int idPaciente,int idTratamiento, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var listaTratamiento= new List<tm_tratamientoBE>();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_Tratamiento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@idTratamiento", idTratamiento);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var objTratamiento= new tm_tratamientoBE(reader);
                                listaTratamiento.Add(objTratamiento);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return listaTratamiento;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
        public bool SetTratamientoIns(tm_tratamientoBE objTratamiento, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var objStpr = new tm_stprBE();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("Set_Tratamiento_Ins", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPaciente", objTratamiento.idPaciente);
                        cmd.Parameters.AddWithValue("@idMedico", objTratamiento.idMedico);
                        cmd.Parameters.AddWithValue("@idEspecialidad", objTratamiento.idEspecialidad);
                        cmd.Parameters.AddWithValue("@fechaInicio", objTratamiento.fechaInicio);
                        cmd.Parameters.AddWithValue("@diagnostico", objTratamiento.diagnostico);
                        cmd.Parameters.AddWithValue("@medicacion", objTratamiento.medicacion);
                        cmd.Parameters.AddWithValue("@notas", objTratamiento.notas);
                        cmd.Parameters.AddWithValue("@reacciones", objTratamiento.reacciones);
                        cmd.Parameters.AddWithValue("@usuarioCrea", objTratamiento.usuarioCrea);
                        conn.Open();
                        cmd.ExecuteNonQuery();                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return true;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return false;
            }
        }
    }
}
