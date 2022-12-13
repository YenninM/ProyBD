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
    public partial class AñadirObservacion : Form
    {
        public AñadirObservacion()
        {
            InitializeComponent();

            if (txtIDAuto.Text == string.Empty)
            {
                gbxModificarA.Enabled = false;
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            var Obse = new Observaciones();
            Obse.Show();
            this.Close();
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            {
                txtObservacion.Text = "";


                if (txtIDAuto.Text == "1")
                {
                    lblEstadoBusqueda.Text = "Auto encontrado";
                    lblEstadoBusqueda.Visible = true;
                    gbxModificarA.Enabled = true;
                }

                if (txtIDAuto.Text == "2")
                {
                    lblEstadoBusqueda.Text = "Auto no encontrado";
                    lblEstadoBusqueda.Visible = true;
                    gbxModificarA.Enabled = false;
                }
            }
        }

        private void AñadirObservacion_Load(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
            lblEstadoBusqueda.Visible = false;
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Añadido con exito");
            txtIDAuto.Text = "";
            txtObservacion.Text = "";
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            if (txtObservacion.Text == string.Empty && txtObservacion.Text != " ")
            {
                btnAñadir.Enabled = false;
            }
            else
            {
                btnAñadir.Enabled = true;
            }
        }
    }
}
