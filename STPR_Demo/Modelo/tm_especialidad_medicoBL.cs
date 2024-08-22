using STPR_UI.Entidad;
using STPR_UI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Modelo
{
    public class tm_especialidad_medicoBL
    {
        public List<tm_especialidad_medicoBE> GetEspecialidadMedico(int idMedico, out string mensajeRetorno) {
            return new tm_especialidad_medicoDA().GetEspecialidadMedico(idMedico, out mensajeRetorno);
        }
    }
}
