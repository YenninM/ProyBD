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
    public partial class ModificarCliente : Form
    {
        Form f;
        bool correo;

        public ModificarCliente()
        {
            InitializeComponent();

            if (txtIDcliente.Text == string.Empty || txtNombreC.Text == string.Empty)
            {
                gbxModificarC.Enabled = false;
            }
        }

        internal void SetPrevForm(Form p)
        {
            f = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtColonia.Text != string.Empty ||
               txtDireccion.Text != string.Empty || txtNombre.Text != string.Empty ||
               txtTelefono.Text != string.Empty)
            {
                MessageBox.Show("Cliente Modificado");
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                txtColonia.Text = "";
            }
            else if(txtCorreo.Text != string.Empty)
            {
                if (correo == false)
                {
                    MessageBox.Show("Correo invalido");
                }
                else
                {
                    MessageBox.Show("Cliente Modificado");
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                    txtCorreo.Text = "";
                    txtTelefono.Text = "";
                    txtColonia.Text = "";
                }

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Dispose();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
          
            if (txtIDcliente.Text == "1")
            {
                lblEstadoBusqueda.Text = "Cliente encontrado";
                gbxModificarC.Enabled = true;

                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtColonia.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();
            }

            if(txtIDcliente.Text == "2")
            {
                lblEstadoBusqueda.Text = "Cliente no encontrado";
                gbxModificarC.Enabled = false;
            }
            
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider3.SetError(this.txtNombre, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider3.Clear();
            }
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider5.SetError(this.txtColonia, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider5.Clear();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtCorreo.Text, pattern))
            {
                errorProvider6.Clear();
                correo = true;
            }
            else
            {
                errorProvider6.SetError(this.txtCorreo, "Correo no valido");
                correo = false;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider7.SetError(this.txtTelefono, "Caracter no admitido");
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider7.Clear();
            }

            if(txtTelefono.Text.Length >= 10)
            {
                e.Handled = true;
                errorProvider7.SetError(this.txtTelefono, "Tamaño maximo");
            }
        }

        private void txtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(this.txtNombreC, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider2.Clear();
            }
        }

        private void txtIDcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(this.txtIDcliente, "Caracter no admitido");
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider1.Clear();
            }
        }
    }
}
