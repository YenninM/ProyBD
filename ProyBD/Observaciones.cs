using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBD
{
    public partial class Observaciones : Form
    {
        public Observaciones()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var modificaciones = new ModificarObservacion();
            modificaciones.Show();
            this.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var añadirObs = new AñadirObservacion();
            añadirObs.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var EliminarObs = new EliminarObservacion();
            EliminarObs.Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var autos = new Autos();
            autos.Show();
            this.Close();
        }
    }
}
