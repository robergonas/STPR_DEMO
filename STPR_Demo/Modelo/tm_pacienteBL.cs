using STPR_UI.Entidad;
using STPR_UI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Modelo
{
    public class tm_pacienteBL
    {
        public List<tm_pacienteBE> get_paciente(int idPaciente, string numeroDocumento, string nombre, string apellidos, out string mensajeRetorno) {
            return new tm_pacienteDA().get_paciente(idPaciente, numeroDocumento, nombre, apellidos, out mensajeRetorno);
        }
    }
}
