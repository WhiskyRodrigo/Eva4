using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    public interface ILecturasDAL
    {
        //Obtenemos las lectura
        List<Lectura> ObtenerLectura();

        //Agregar lectura
        void AgregarLectura(Lectura lectura);

        void Eliminar(string boleta);
    }
}

