using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    public interface IUsuarioDAL
    {
        List<Usuario> ObtenerUsuarios();

        List<Usuario> ObtenerUsuarios(string estado);

        Usuario Obtener(int id);

        void AgregarUsuario(Usuario usuario);

        void EliminarUsuario(int id);

    }
}
