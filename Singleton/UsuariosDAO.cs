using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class UsuariosDAO
    {
        List<Usuarios> _listaUsuarios = new List<Usuarios>();

        private static UsuariosDAO _usuarioDAO = new UsuariosDAO();


        private UsuariosDAO()
        {

        }
        public static UsuariosDAO getInstancia()
        {
            return _usuarioDAO;
        }


        public void agregarUsuario(Usuarios u)
        {
            _listaUsuarios.Add(u);
        }

        public List<Usuarios> getUsuarios()
        {
            return _listaUsuarios;
        }

    }
}
