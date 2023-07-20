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
        this.medidorDB Usuarios.Add(usuario);
        this.medidorDB.SaveChanges();
    }

    public void EliminarMedidor(int id)
    {

        Usuario usuario = this.usuarioDB.Usuarios.Find(id);
        this.medidorDB.Usuarios.Remove(usuario);
        this.medidorDB.SaveChanges();
    }

    public Usuario Obtener(int id)
    {
        return this.medidorDB.Usuarios.Find(id);
    }

    public List<Usuario> ObtenerUsuarios()
    {
        return this.medidorDB.Usuarios.ToList();
    }

    public void Actualizar(Usuario a)
    {
        Usuario aOriginal = this.medidorDB.Usuarios.Find(a.Id);
        aOriginal.Rut = a.Rut;
        aOriginal.Nombre = a.Nombre;
        aOriginal.Contraseña = a.Contraseña;
        aOriginal.Correo = a.Correo;
        this.medidorDB.SaveChanges();
    }

    public List<Usuarios> ObtenerUsuarios(string estado)
    {
        //LINQ
        var query = from a in this.medidorDB.Usuarios
                    where a.Estado == estado
                    select a;
        return query.ToList();
    }
}
}