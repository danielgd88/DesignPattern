using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuariosDAO _usuarioDAO = UsuariosDAO.getInstancia();
            UsuariosDAO _usuarioDAO2 = UsuariosDAO.getInstancia();


            _usuarioDAO.agregarUsuario(new Usuarios()
            {
                id = 1,
                nombre = "Admin",
                password = "1234"
            });


            _usuarioDAO2.agregarUsuario(new Usuarios()
            {
                id = 1,
                nombre = "Admin",
                password = "1234"
            });



        }
    }
}
