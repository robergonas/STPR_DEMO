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
using Twilio.TwiML.Voice;

namespace STPR_UI.Repositorio
{
    public class tm_stprDA
    {
        public tm_stprBE GetStpr(int idStpr, out string mensajeRetorno) {
            mensajeRetorno = string.Empty;
            try
            {
                var objStpr= new tm_stprBE();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("get_stpr", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idStpr", idStpr);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                objStpr = new tm_stprBE(reader);
                            }
                        }
                    }
                }

                mensajeRetorno = "Ok|Proceso realizado de manera satisfactoria";
                return objStpr;
            }
            catch (Exception ex)
            {
                mensajeRetorno = "NO-OK|" + ex.Message;
                return null;
            }
        }
        public bool set_stpr_ins( tm_stprBE objSTPR, out string mensajeRetorno)
        {
            mensajeRetorno = string.Empty;
            try
            {                
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["StrConn"]))
                {
                    using (SqlCommand cmd = new SqlCommand("set_stpr_ins", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPaciente", objSTPR.idPaciente);
                        cmd.Parameters.AddWithValue("@horaDistancia", objSTPR.horaDistancia);
                        cmd.Parameters.AddWithValue("@horaAdicional", objSTPR.horaAdicional);
                        cmd.Parameters.AddWithValue("@horaReferencia", objSTPR.horaReferencia);
                        cmd.Parameters.AddWithValue("@usuarioCrea", objSTPR.usuarioCrea);
                        cmd.Parameters.AddWithValue("@sms", objSTPR.sms);
                        cmd.Parameters.AddWithValue("@multimedia", objSTPR.multimedia);
                        cmd.Parameters.AddWithValue("@mail", objSTPR.mail);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
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
