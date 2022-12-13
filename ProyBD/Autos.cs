using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBD
{
    public partial class Autos : Form
    {
        public Autos()
        {
            InitializeComponent();
        }

        private void lblBucarcarro_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDauto.Text = "";
            txtNCliente.Text= "";
            txtMarca.Text = "";
            txtMotor.Text = "";
            txtAño.Text = "";
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
        }

        private void txtIDauto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(this.txtIDauto, "Caracter no admitido");
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider1.Clear();
            }

        }

        private void txtNCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(this.txtNCliente, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider2.Clear();
            }

        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMotor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                errorProvider5.SetError(this.txtAño, "Fecha no valida");
            }

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                errorProvider5.Clear();
            }
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            var obser = new Observaciones();
            obser.Show();
            this.Close();
        }

        private void txtAño_Leave(object sender, EventArgs e)
        {
            
            string pattern = "^([0-9]{2,})([-])([0-9]{2,})([-])([0-9]{4,})$";

            if (Regex.IsMatch(txtAño.Text, pattern))
            {
                errorProvider5.Clear();
            }
            else
            {
                errorProvider5.SetError(this.txtAño, "Año no valido");
            }
        }
    }
}
