using STPR_UI.Entidad;
using STPR_UI.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPR_UI.Modelo
{
    public class tm_tratamientoBL
    {
        public List<TratamientiCitaBE> GetTratamientoCita(int idTratamiento, int idPaciente, out string mensajeRetorno) {
            return new tm_tratamientoDA().GetTratamientoCita(idTratamiento, idPaciente, out mensajeRetorno);
        }
        public List<tm_tratamientoBE> GetTratamiento(int idPaciente,int idTratamiento, out string mensajeRetorno) {
            return new tm_tratamientoDA().GetTratamiento(idPaciente,idTratamiento, out mensajeRetorno);
        }
        public bool SetTratamientoIns(tm_tratamientoBE objTratamiento, out string mensajeRetorno) {
            return new tm_tratamientoDA().SetTratamientoIns(objTratamiento, out mensajeRetorno);
        }
    }
}
