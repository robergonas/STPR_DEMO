using STPR_UI.Entidad;
using STPR_UI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Modelo
{
    public class tm_usuarioBL
    {
        public void get_usuario(string usuario, out string mensajeRetorno) {
            new tm_usuarioDA().get_usuario(usuario, out mensajeRetorno);
        }
    }
}
