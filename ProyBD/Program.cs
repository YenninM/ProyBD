using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string usuarioActual = null;

            var usuario =
                new Usuario("admin", "1");
            var usuario2 =
                new Usuario("empleado", "2");

            Usuario.listaUsuarios.Add(usuario);
            Usuario.listaUsuarios.Add(usuario2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaPrincipal());
        }
    }
}
