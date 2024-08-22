using STPR_UI.Entidad;
using STPR_UI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Modelo
{
    public class tm_medicoBL
    {
        public List<tm_medicoBE> GetMedico(int idMedico, string datosMedico, out string mensajeRetorno) {
            return new tm_medicoDA().GetMedico(idMedico, datosMedico, out mensajeRetorno);
        }
    }
}
