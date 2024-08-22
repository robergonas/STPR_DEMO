using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Jwt.AccessToken;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Http;
using System.Drawing;
using Twilio.TwiML.Messaging;

namespace STPR_UI.Modelo
{
    public class utilitarioBL
    {
        private static readonly string botToken = "";
        private static readonly string chatIdRGP = "";
        private static readonly string chatIdAG = ";
        public string MensajeNotificacion(string datosPaciente, string fechaCita, string horaCita, string especialidad, string datosMedico)
        {
            var mensaje = "*** Instrucciones Importantes Antes de su Cita Médica ***";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Estimado/a " + datosPaciente+",";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Esperamos que se encuentre bien. Nos gustaría recordarle su próxima cita médica programada para:";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Fecha: "+ fechaCita;
            mensaje += Environment.NewLine + "Hora: "+horaCita;
            mensaje += Environment.NewLine + "Especialidad: "+especialidad;
            mensaje += Environment.NewLine + "Médico: " + datosMedico;
            mensaje += Environment.NewLine + "Para asegurar que su cita transcurra de manera fluida y eficaz, le solicitamos que tenga en cuenta las siguientes indicaciones:";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Indicaciones: [Insertar las indicaciones que desee dar al paciente ...]";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Documentación: [insertar documentos necesarios ...]";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Ayuno: [insertar requerimientos de ayuno ....]";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Medicamentos: [indicar la toma u omisión de medicamentos ... ]";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "le solicitamos llegar media hora antes de la hora programada.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + " Si tiene alguna pregunta o inquietud sobre la cita, no dude en contactarnos antes de la fecha programada. Estamos aquí para ayudarle.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Si por alguna razón no puede asistir a la cita, le rogamos que nos lo comunique con la mayor antelación posible para poder reprogramarla.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Gracias por su cooperación y confianza en nuestros servicios.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Saludos cordiales,";
            mensaje += Environment.NewLine + "Equipo - STPR";
            mensaje += Environment.NewLine + "Teléfono: +01 506 6123";

            return mensaje;
        }
        public string MensajeNotificacionCorreo(string datosPaciente, string titulo, string textoCorreo)
        {
            var mensaje = "<!DOCTYPE html>";
            mensaje += "<html lang='es'>";
            mensaje += "<head>";
            mensaje += "<meta charset='UTF-8'>";
            mensaje += "<meta name='viewport' content='width=device-width, initial-scale=1.0'>";
            mensaje += "<title>" + titulo + "</title>";
            mensaje += "<style>";
            mensaje += "body {";
            mensaje += "font-family: Arial, sans-serif;";
            mensaje += "background-color: #f0f8ff;!;";
            mensaje += "color: #333;";
            mensaje += "margin: 0;";
            mensaje += "padding: 0;!;";
            mensaje += "}";
            mensaje += ".container {";
            mensaje += "max-width: 800px;";
            mensaje += "margin: 50px auto;";
            mensaje += "padding: 20px;";
            mensaje += "background-color: #fff;";
            mensaje += "border-radius: 8px;";
            mensaje += "box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);";
            mensaje += "}";
            mensaje += " h1 {";
            mensaje += " color: #0056b3;";
            mensaje += "}";
            mensaje += " p {";
            mensaje += "line-height: 1.6;";
            mensaje += "}";
            mensaje += ".button {";
            mensaje += "display: inline-block;";
            mensaje += "padding: 10px 20px;";
            mensaje += "margin-top: 20px;";
            mensaje += "font-size: 16px;";
            mensaje += "color: #fff;";
            mensaje += "background-color: #0056b3;";
            mensaje += "text-decoration: none;";
            mensaje += "border-radius: 5px;";
            mensaje += "}";
            mensaje += ".button:hover {";
            mensaje += "background-color: #004494;";
            mensaje += "}";
            mensaje += "</style>";
            mensaje += "</head>";
            mensaje += "<body>";
            mensaje += "<div class='container'>";
            mensaje += "<p>Estimado/a " + datosPaciente + ",</p>";
            mensaje += "<p>" + textoCorreo.Replace(Environment.NewLine, "<br>") + "</p>";
            mensaje += "</div>";
            mensaje += "</body>";
            mensaje += "</html>";
            return mensaje;
        }
        public string GenerarCitaCorreo(string titulo, string datosPaciente, string fechaCita, string horaCita, string especialidad, string datosMedico)
        {
            var mensaje = "<!DOCTYPE html>";
            mensaje += "<html lang='es'>";
            mensaje += "<head>";
            mensaje += "<meta charset='UTF-8'>";
            mensaje += "<meta name='viewport' content='width=device-width, initial-scale=1.0'>";
            mensaje += "<title>" + titulo + "</title>";
            mensaje += "<style>";
            mensaje += "body {";
            mensaje += "font-family: Arial, sans-serif;";
            mensaje += "background-color: #f0f8ff;!;";
            mensaje += "color: #333;";
            mensaje += "margin: 0;";
            mensaje += "padding: 0;!;";
            mensaje += "}";
            mensaje += ".container {";
            mensaje += "max-width: 800px;";
            mensaje += "margin: 50px auto;";
            mensaje += "padding: 20px;";
            mensaje += "background-color: #fff;";
            mensaje += "border-radius: 8px;";
            mensaje += "box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);";
            mensaje += "}";
            mensaje += " h1 {";
            mensaje += " color: #0056b3;";
            mensaje += "}";
            mensaje += " p {";
            mensaje += "line-height: 1.6;";
            mensaje += "}";
            mensaje += ".button {";
            mensaje += "display: inline-block;";
            mensaje += "padding: 10px 20px;";
            mensaje += "margin-top: 20px;";
            mensaje += "font-size: 16px;";
            mensaje += "color: #fff;";
            mensaje += "background-color: #0056b3;";
            mensaje += "text-decoration: none;";
            mensaje += "border-radius: 5px;";
            mensaje += "}";
            mensaje += ".button:hover {";
            mensaje += "background-color: #004494;";
            mensaje += "}";
            mensaje += "</style>";
            mensaje += "</head>";
            mensaje += "<body>";
            mensaje += "<div class='container'>";
            mensaje += "<p>Estimado/a " + datosPaciente + ",</p>";
            mensaje += "<p>Nos complace informarle que se ha generado automáticamente una cita médica para usted como parte de nuestro programa de atención continua..</p>";
            mensaje += " <br>";
            mensaje += " <p>Detalles de la Cita:.</p>";
            mensaje += " <br>";
            mensaje += "<p>Fecha: " + fechaCita + "</p>";
            mensaje += "<p>Hora: " + horaCita + "</p>";
            mensaje += "<p>Especialidad: " + especialidad + "</p>";
            mensaje += "<p>Médico: " + datosMedico + "</p>";
            mensaje += "<p>Esta cita ha sido programada para asegurar que reciba la atención necesaria sin demoras. Si por alguna razón no puede asistir a la cita, le rogamos que se comunique con nosotros a la mayor brevedad para reprogramarla.</p>";
            mensaje += " <br>";
            mensaje += "<p>Si tiene alguna pregunta o necesita asistencia adicional, no dude en ponerse en contacto con nuestro equipo a través del número [Número de Contacto] o respondiendo a este correo.</p>";
            mensaje += " <br>";
            mensaje += "<p>Estamos aquí para ayudarle en todo lo que necesite.</p>";
            mensaje += " <br>";
            mensaje += "<p>Gracias por confiar en nosotros para su cuidado.</p>";
            mensaje += "<br>";
            mensaje += "<p>Saludos cordiales,</p>";
            mensaje += "<p>Equipo - STPR</p>";
            mensaje += "<p>Teléfono: +01 506 6123</p>";
            mensaje += "</div>";
            mensaje += "</body>";
            mensaje += "</html>";
            return mensaje;
        }
        public string GenerarCitaMultimedia(string datosPaciente, string fechaCita, string horaCita, string especialidad, string datosMedico)
        {
            string mensaje = "*** Confirmación de Cita Médica Automática ***";
            mensaje += Environment.NewLine + "Estimado/a " + datosPaciente + ",";
            mensaje += Environment.NewLine + "Nos complace informarle que se ha generado automáticamente una cita médica para usted como parte de nuestro programa de atención continua.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Detalles de la Cita:";
            mensaje += Environment.NewLine + "Fecha: " + fechaCita;
            mensaje += Environment.NewLine + "Hora: " + horaCita;
            mensaje += Environment.NewLine + "Especialista: " + especialidad;
            mensaje += Environment.NewLine + "Médico: " + datosMedico;
            mensaje += Environment.NewLine + "Esta cita ha sido programada para asegurar que reciba la atención necesaria sin demoras. Si por alguna razón no puede asistir a la cita, le rogamos que se comunique con nosotros a la mayor brevedad para reprogramarla.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Si tiene alguna pregunta o necesita asistencia adicional, no dude en ponerse en contacto con nuestro equipo a través del número 991992989.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Estamos aquí para ayudarle en todo lo que necesite.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Gracias por confiar en nosotros para su cuidado.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Saludos cordiales,";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Equipo - STPR";
            mensaje += Environment.NewLine + "Teléfono: +01 506 6123";

            return mensaje;

        }
        public string GenerarCitaSMS(string datosPaciente, string fechaCita, string horaCita, string especialidad, string datosMedico)
        {
            string mensaje = "*** Confirmación de Cita Médica Automática ***";
            mensaje += Environment.NewLine + "Estimado/a " + datosPaciente + ",";
            mensaje += Environment.NewLine + "Nos complace informarle que se ha generado automáticamente una cita médica para usted como parte de nuestro programa de atención continua.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Detalles de la Cita:";
            mensaje += Environment.NewLine + "Fecha: " + fechaCita;
            mensaje += Environment.NewLine + "Hora: " + horaCita;
            mensaje += Environment.NewLine + "Especialista: " + especialidad;
            mensaje += Environment.NewLine + "Médico: " + datosMedico;
            mensaje += Environment.NewLine + "Esta cita ha sido programada para asegurar que reciba la atención necesaria sin demoras. Si por alguna razón no puede asistir a la cita, le rogamos que se comunique con nosotros a la mayor brevedad para reprogramarla.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Si tiene alguna pregunta o necesita asistencia adicional, no dude en ponerse en contacto con nuestro equipo a través del número 991992989.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Estamos aquí para ayudarle en todo lo que necesite.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Gracias por confiar en nosotros para su cuidado.";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Saludos cordiales,";
            mensaje += Environment.NewLine + "";
            mensaje += Environment.NewLine + "Equipo - STPR";
            mensaje += Environment.NewLine + "Teléfono: +01 506 6123";

            return mensaje;

        }
        public string NotificacionCorreo(string datosPaciente, string notificacion)
        {
            var mensaje = "<!DOCTYPE html>";
            mensaje += "<html lang='es'>";
            mensaje += "<head>";
            mensaje += "<meta charset='UTF-8'>";
            mensaje += "<meta name='viewport' content='width=device-width, initial-scale=1.0'>";
            mensaje += "<title>Bienvenida al Sietema de Telegestión para Pacientes Rurales (STPR)</title>";
            mensaje += "<style>";
            mensaje += "body {";
            mensaje += "font-family: Arial, sans-serif;";
            mensaje += "background-color: #f0f8ff;!;";
            mensaje += "color: #333;";
            mensaje += "margin: 0;";
            mensaje += "padding: 0;!;";
            mensaje += "}";
            mensaje += ".container {";
            mensaje += "max-width: 800px;";
            mensaje += "margin: 50px auto;";
            mensaje += "padding: 20px;";
            mensaje += "background-color: #fff;";
            mensaje += "border-radius: 8px;";
            mensaje += "box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);";
            mensaje += "}";
            mensaje += " h1 {";
            mensaje += " color: #0056b3;";
            mensaje += "}";
            mensaje += " p {";
            mensaje += "line-height: 1.6;";
            mensaje += "}";
            mensaje += ".button {";
            mensaje += "display: inline-block;";
            mensaje += "padding: 10px 20px;";
            mensaje += "margin-top: 20px;";
            mensaje += "font-size: 16px;";
            mensaje += "color: #fff;";
            mensaje += "background-color: #0056b3;";
            mensaje += "text-decoration: none;";
            mensaje += "border-radius: 5px;";
            mensaje += "}";
            mensaje += ".button:hover {";
            mensaje += "background-color: #004494;";
            mensaje += "}";
            mensaje += "</style>";
            mensaje += "</head>";
            mensaje += "<body>";
            mensaje += "<div class='container'>";
            mensaje += "<h1>Notificación al Paciente</h1>";
            mensaje += "<p>Estimado/a " + datosPaciente + ",</p>";
            mensaje += "<p>" + notificacion + ".</p>";
            mensaje += "<p>Equipo STPR a tu servicio</p>";
            mensaje += "<p>Número de contacto +01 506 6123</p>";
            mensaje += "</div>";
            mensaje += "</body>";
            mensaje += "</html>";
            return mensaje;
        }
        public string ContenidoCorreo(string datosPaciente)
        {
            var mensaje = "<!DOCTYPE html>";
            mensaje += "<html lang='es'>";
            mensaje += "<head>";
            mensaje += "<meta charset='UTF-8'>";
            mensaje += "<meta name='viewport' content='width=device-width, initial-scale=1.0'>";
            mensaje += "<title>Bienvenida al Sietema de Telegestión para Pacientes Rurales (STPR)</title>";
            mensaje += "<style>";
            mensaje += "body {";
            mensaje += "font-family: Arial, sans-serif;";
            mensaje += "background-color: #f0f8ff;!;";
            mensaje += "color: #333;";
            mensaje += "margin: 0;";
            mensaje += "padding: 0;!;";
            mensaje += "}";
            mensaje += ".container {";
            mensaje += "max-width: 800px;";
            mensaje += "margin: 50px auto;";
            mensaje += "padding: 20px;";
            mensaje += "background-color: #fff;";
            mensaje += "border-radius: 8px;";
            mensaje += "box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);";
            mensaje += "}";
            mensaje += " h1 {";
            mensaje += " color: #0056b3;";
            mensaje += "}";
            mensaje += " p {";
            mensaje += "line-height: 1.6;";
            mensaje += "}";
            mensaje += ".button {";
            mensaje += "display: inline-block;";
            mensaje += "padding: 10px 20px;";
            mensaje += "margin-top: 20px;";
            mensaje += "font-size: 16px;";
            mensaje += "color: #fff;";
            mensaje += "background-color: #0056b3;";
            mensaje += "text-decoration: none;";
            mensaje += "border-radius: 5px;";
            mensaje += "}";
            mensaje += ".button:hover {";
            mensaje += "background-color: #004494;";
            mensaje += "}";
            mensaje += "</style>";
            mensaje += "</head>";
            mensaje += "<body>";
            mensaje += "<div class='container'>";
            mensaje += "<h1>Bienvenido/a al Sistema de Telegestión Para Pacientes Rurales (STPR)</h1>";
            mensaje += "<p>Estimado/a " + datosPaciente + ",</p>";
            mensaje += "<p>Nos complace darle la bienvenida a nuestro Programa de Telegestión. Este programa está diseñado para brindarle la mejor atención médica desde la comodidad de su hogar.</p>";
            mensaje += " <p>A través de este programa, podrá acceder a consultas virtuales con nuestros especialistas, recibir asesoramiento personalizado, y realizar un seguimiento de su salud de manera eficiente y segura.</p>";
            mensaje += "<p>Si tiene alguna pregunta o necesita asistencia, no dude en ponerse en contacto con nosotros. Estamos aquí para ayudarlo/a en cada paso del camino.</p>";
            mensaje += "<p>Gracias por confiar en nosotros para su cuidado y bienestar.</p>";
            mensaje += "<p>Equipo STPR a tu servicio</p>";
            mensaje += "<p>Número de contacto +01 506 6123</p>";            
            mensaje += "</div>";
            mensaje += "</body>";
            mensaje += "</html>";
            return mensaje;
        }
        public string ContenidoMultimedia(string datosPaciente)
        {
            var mensaje = "Bienvenido/a al Sistema de Telegestión Para Pacientes Rurales (STPR)";
            mensaje += Environment.NewLine + "Estimado/a," + datosPaciente;
            mensaje += Environment.NewLine + "Nos complace darle la bienvenida a nuestro Programa de Telegestión. Este programa está diseñado para brindarle la mejor atención médica desde la comodidad de su hogar.";
            mensaje += Environment.NewLine + "A través de este programa, podrá acceder a consultas virtuales con nuestros especialistas, recibir asesoramiento personalizado, y realizar un seguimiento de su salud de manera eficiente y segura.";
            mensaje += Environment.NewLine + "Si tiene alguna pregunta o necesita asistencia, no dude en ponerse en contacto con nosotros. Estamos aquí para ayudarlo/a en cada paso del camino.";
            mensaje += Environment.NewLine + "Gracias por confiar en nosotros para su cuidado y bienestar.";
            mensaje += Environment.NewLine + "Equipo STPR a tu servicio";
            mensaje += Environment.NewLine + "Número de contacto +01 506 6123";            

            return mensaje;
        }
        public string ContenidoSMS(string datosPaciente)
        {
            var mensaje = "Bienvenido/a al Sistema de Telegestión Para Pacientes Rurales (STPR)";
            mensaje += Environment.NewLine + "Estimado/a," + datosPaciente;
            mensaje += Environment.NewLine + "Nos complace darle la bienvenida a nuestro Programa de Telegestión. Este programa está diseñado para brindarle la mejor atención médica desde la comodidad de su hogar.";
            mensaje += Environment.NewLine + "A través de este programa, podrá acceder a consultas virtuales con nuestros especialistas, recibir asesoramiento personalizado, y realizar un seguimiento de su salud de manera eficiente y segura.";
            mensaje += Environment.NewLine + "Si tiene alguna pregunta o necesita asistencia, no dude en ponerse en contacto con nosotros. Estamos aquí para ayudarlo/a en cada paso del camino.";
            mensaje += Environment.NewLine + "Gracias por confiar en nosotros para su cuidado y bienestar.";
            mensaje += Environment.NewLine + "Equipo STPR a tu servicio";
            mensaje += Environment.NewLine + "Número de contacto +01 506 6123";            

            return mensaje;
        }
        public string EnviarMultimedia(string datosPaciente, string telefonoPaciente, string contenidoTelegram, out string mensajeRetorno)
        {
            try
            {
                var chatId = string.Empty;
                if (telefonoPaciente == "991972989") chatId = chatIdRGP; else chatId = chatIdAG;
                var apiUrl = $"https://api.telegram.org/bot{botToken}/sendMessage?chat_id={chatId}&text={Uri.EscapeDataString(contenidoTelegram)}";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return mensajeRetorno = "OK|Proceso realizado de manera satisfactoría.";
                    }
                    else
                    {
                        string errorDetails = response.Content.ReadAsStringAsync().Result;
                        return mensajeRetorno = $"No-OK| Error al enviar el mensaje: {response.ReasonPhrase}. Detalles: {errorDetails}";
                    }
                }
            }
            catch (Exception ex)
            {
                return mensajeRetorno = "NO-OK|" + ex.Message;
            }
        }
        public string EnviarSMS(string telefonoPaciente, string telefonoVirtual, string cuentaSID, string token, string contenidoSMS, out string mensajeRetorno)
        {
            try
            {
                TwilioClient.Init(cuentaSID, token);

                var messageOptions = new CreateMessageOptions(new PhoneNumber("+51" + telefonoPaciente));
                messageOptions.From = new PhoneNumber(telefonoVirtual);
                messageOptions.Body = contenidoSMS;

                var message = MessageResource.Create(messageOptions);
                return mensajeRetorno = "OK|Proceso realizado de manera satisfactoría.";
            }
            catch (Exception ex)
            {
                return mensajeRetorno = "NO-OK|" + ex.Message;
            }
        }
        public string EnviarCorreo(string datosPaciente, string correo, string contenidoCorreo, string asunto, out string mensajeRetorno)
        {
            var mensaje = new MimeMessage();
            mensaje.From.Add(new MailboxAddress("STPR", "laboratorioeducativopersonal@gmail.com"));
            mensaje.To.Add(new MailboxAddress(datosPaciente, correo));
            mensaje.Subject = asunto;
            mensaje.Body = new TextPart("html")
            {
                Text = contenidoCorreo
            };

            using (var cliente = new SmtpClient())
            {
                try
                {
                    cliente.Connect("smtp.gmail.com", 587, false);
                    cliente.Authenticate("laboratorioeducativopersonal@gmail.com", "cpmb cwoc wyvy wwvu");
                    cliente.Send(mensaje);
                    return mensajeRetorno = "OK|Proceso realizado de manera satisfactoría.";
                }
                catch (Exception ex)
                {
                    return mensajeRetorno = "NO-OK|" + ex.Message;
                }
                finally
                {
                    cliente.Disconnect(true);
                }
            }
        }
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public bool VerificarClave(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
