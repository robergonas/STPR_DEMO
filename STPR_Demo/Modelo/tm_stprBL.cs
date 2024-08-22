using STPR_UI.Entidad;
using STPR_UI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Modelo
{
    public class tm_stprBL
    {
        public tm_stprBE GetStpr(int idStpr, out string mensajeRetorno) {
            return new tm_stprDA().GetStpr(idStpr, out mensajeRetorno);
        }
        public bool set_stpr_ins(tm_stprBE objSTPR, out string mensajeRetorno)
        {
            return new tm_stprDA().set_stpr_ins(objSTPR, out mensajeRetorno);
        }
    }
}
