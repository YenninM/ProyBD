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
    public partial class ModificarObservacion : Form
    {
        public ModificarObservacion()
        {
            InitializeComponent();


            if(txtIDAuto.Text == string.Empty)
            {
                gbxModificarA.Enabled = false;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Reemplazado con exito");
            txtIDAuto.Text = "";
            txtObservacion.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var Obser = new Observaciones();
            Obser.Show();
            this.Close();
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            if(txtObservacion.Text == string.Empty && txtObservacion.Text != " ")
            {
                btnModificar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
            }
        }

        private void ModificarObservacion_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            lblEstadoBusqueda.Visible = false;
        }
    }
}
