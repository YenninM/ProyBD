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
    public partial class EliminarObservacion : Form
    {
        public EliminarObservacion()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta =
                MessageBox.Show(
                    "¿Deseas realmente eliminar?",
                    "Mensaje del Sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Observacion eliminada");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var obser = new Observaciones();
            obser.Show();
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtIDAuto.Text == "1")
            {
                lblEstadoBusqueda.Text = "Auto encontrado";
                lblEstadoBusqueda.Visible = true;
                btnEliminar.Enabled = true;
            }

            if (txtIDAuto.Text == "2")
            {
                lblEstadoBusqueda.Text = "Auto no encontrado";
                lblEstadoBusqueda.Visible = true;
            }
        }

        private void EliminarObservacion_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            lblEstadoBusqueda.Visible = false;
        }
    }
}
