using STPR_UI.Entidad;
using STPR_UI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Modelo
{
    public class tm_citaBL
    {
        public List<tm_citaBE> SetGenerarCita(int idPaciente, int idMedico, int idEspecialidad, int usuCrea, out string mensajeRetorno) {
            return new tm_citaDA().SetGenerarCita(idPaciente, idMedico, idEspecialidad, usuCrea, out mensajeRetorno);
        }
        public List<tm_citaBE> GetCita(int idPaciente, int idMedico, int idEspecialidad, out string mensajeRetorno) {
            return new tm_citaDA().GetCita(idPaciente, idMedico, idEspecialidad, out mensajeRetorno);
        }
    }
}
