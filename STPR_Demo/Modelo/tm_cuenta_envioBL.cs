using STPR_UI.Entidad;
using STPR_UI.Repositorio;

namespace STPR_UI.Modelo
{
    public class tm_cuenta_envioBL
    {        
        public tm_cuenta_envioBE get_cuenta_envio(string telefonoPaciente, out string mensajeRetorno) {
            return new tm_cuenta_enviaDA().get_cuenta_envio(telefonoPaciente, out mensajeRetorno);
        }
    }
}
