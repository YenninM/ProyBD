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
    public partial class EliminarCliente : Form
    {
        Form f;

        public EliminarCliente()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
        }

        internal void SetPrevForm(Form p)
        {
            f = p;
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta =
                MessageBox.Show(
                    "¿Deseas realmente eliminar al cliente?",
                    "Mensaje del Sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Cliente eliminado");
                btnEliminar.Enabled = false;
            }

            txtIDcliente2.Text = "";
            txtNombreC2.Text = "";
            lblEstadoBusqueda.Text = "";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtIDcliente2.Text == "1")
            {
                lblEstadoBusqueda.Text = "Cliente encontrado";
                btnEliminar.Enabled = true;
            }

            if (txtIDcliente2.Text == "2")
            {
                lblEstadoBusqueda.Text = "Cliente no encontrado";
                btnEliminar.Enabled = false;

            }
        }

        private void txtIDcliente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(this.txtIDcliente2, "Caracter no admitido");
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider1.Clear();
            }
        }

        private void txtNombreC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(this.txtNombreC2, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider2.Clear();
            }
        }
    }
}
