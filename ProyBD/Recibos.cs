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
    public partial class Recibos : Form
    {
        public Recibos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(txtNCliente.Text == string.Empty && txtIDAuto.Text == string.Empty)
            {
                MessageBox.Show("Campos vacios");
            }
            else if(txtNCliente.Text == "1" || txtIDAuto.Text == "1")
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Ubicado exitosamente";
                btnGenerar.Enabled = true;
            }
            else
            {
                lblStatus.Text = "Sin coincidencias";
                btnGenerar.Enabled = false;
            }
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
            lblStatus.Visible = false;
        }

        private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(this.txtNCliente, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider2.Clear();
            }
        }

        private void txtIDAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider2.SetError(this.txtIDAuto, "Caracter no admitido");
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider2.Clear();
            }
        }
    }
}
