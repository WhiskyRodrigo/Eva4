using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidor();

        List<Medidor> ObtenerMedidor(string estado);

        Medidor Obtener(int id);

        void AgregarMedidor(Medidor medidor);

        void EliminarMedidor(int id);

    }
}
