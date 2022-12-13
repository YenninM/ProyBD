using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBD
{
    class Usuario
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        private string nombre;
        private string contraseña;

        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        public string Nombre { get => nombre; }
        public string Contraseña { get => contraseña; }

        public static Usuario IngresarSistema(string contraseña, String correo)
        {
            var resultado = (from x in listaUsuarios
                             where x.Contraseña == contraseña
                             select x).FirstOrDefault();
            return resultado;
        }

        public static Usuario BuscarPorNombre(string nombre)
        {
            var resultado = (from x in listaUsuarios
                             where x.Nombre == nombre
                             select x).FirstOrDefault();
            return resultado;
        }
    }
}
