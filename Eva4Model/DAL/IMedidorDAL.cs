using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    public interface IMedidorDAL
    {
        //Obtenemos medidor
        List<Medidor> ObtenerMedidor();

        List<Medidor> ObtenerMedidor(string estado);

        Medidor Obtener(int id);

        //Agregamos el medidor
        void AgregarMedidor(Medidor medidor);
        //Eliminamos medidor.
        void EliminarMedidor(int id);

    }
}
