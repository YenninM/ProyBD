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
    public partial class AñadirClientes : Form
    {
        Form f;
        bool correo;

        public AñadirClientes()
        {
            InitializeComponent();

            
           
        }

        internal void SetPrevForm(Form p)
        {
            f = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtColonia.Text != string.Empty && txtCorreo.Text != string.Empty &&
               txtDireccion.Text != string.Empty && txtNombre.Text != string.Empty &&
               txtTelefono.Text != string.Empty)
            {

                if (correo == false)
                {
                    MessageBox.Show("Correo invalido");
                }
                else
                {
                    MessageBox.Show("Cliente Añadido");
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";
                    txtColonia.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Campos en blanco");
            }
        }

        private void AñadirClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(this.txtNombre, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider1.Clear();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider2.SetError(this.txtColonia, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider2.Clear();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider4.SetError(this.txtTelefono, "Caracter no admitido");
                
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider4.Clear();
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtCorreo.Text, pattern))
            {
                errorProvider3.Clear();
                correo = true;
            }
            else
            {
                errorProvider3.SetError(this.txtCorreo, "Correo no valido");
                correo = false;
            }
        }
    }
}
