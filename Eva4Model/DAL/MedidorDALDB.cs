using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    public class MedidorDALDB : IMedidorDAL
    {
        private MedidorDBEntities medidorDB = new MedidorDBEntities();
        public void AgregarMedidor(Medidor medidor)
        {
            this.medidorDB Medidores.Add(medidor);
            this.medidorDB.SaveChanges();
        }

        public void EliminarMedidor (int id)
        {

            Medidor medidor = this.medidorDB.Medidores.Find(id);
            this.medidorDB.Medidores.Remove(medidor);
            this.medidorDB.SaveChanges();
        }

        public Medidor Obtener(int id)
        {
            return this.medidorDB.Medidores.Find(id);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return this.medidorDB.Medidores.ToList();
        }

        public void Actualizar(Medidor a)
        {
            Medidor aOriginal = this.medidorDB.Medidores.Find(a.Id);
            aOriginal.Rut = a.Rut;
            aOriginal.Nombre = a.Nombre;
            aOriginal.Contraseña = a.Contraseña;
            aOriginal.Correo = a.Correo;
            this.medidorDB.SaveChanges();
        }

        public List<Medidores> ObtenerMedidores(string estado)
        {
            //LINQ
            var query = from a in this.medidorDB.Medidores
                        where a.Estado == estado
                        select a;
            return query.ToList();
        }
    }
}
