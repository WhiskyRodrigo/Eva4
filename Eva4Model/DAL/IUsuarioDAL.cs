using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    //Obtenemos medidor
    List<Usuario> ObtenerUsuario();

    List<Usuario> ObtenerUsuario(string estado);

    Medidor Obtener(int id);

    //Agregamos el medidor
    void AgregarUsuario(Medidor medidor);
    //Eliminamos medidor.
    void EliminarUsuario(int id);

}
}