using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    public class UsuarioDALDB : IUsuarioDAL
    {
        private MedidorDBEntities medidorDB = new MedidorDBEntities();
        public void AgregarUsuario(Usuario usuario)
        {
            this.medidorDB Usuario.Add(usuario);
            this.medidorDB.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {

            Usuario usuario = this.medidorDB.Usuario.Find(id);
            this.medidorDB.Usuario.Remove(usuario);
            this.medidorDB.SaveChanges();
        }

        public Usuario Obtener(int id)
        {
            return this.medidorDB.Usuario.Find(id);
        }

        public List<Asistente> ObtenerAsistentes()
        {
            return this.eventoDB.Asistentes.ToList();
        }

        public void Actualizar(Asistente a)
        {
            Asistente aOriginal = this.eventoDB.Asistentes.Find(a.Id);
            aOriginal.Nombre = a.Nombre;
            aOriginal.Apellido = a.Apellido;
            aOriginal.Edad = a.Edad;
            this.eventoDB.SaveChanges();
        }

        public List<Asistente> ObtenerAsistentes(string estado)
        {
            //LINQ
            var query = from a in this.eventoDB.Asistentes
                        where a.Estado == estado
                        select a;
            return query.ToList();
        }
    }
}
