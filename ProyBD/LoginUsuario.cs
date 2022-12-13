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
    public partial class LoginUsuario : Form
    {

        public Boolean salirSistema;
        public int IntentosLogueo;
        public bool salir = false;

        public LoginUsuario()
        {
            IntentosLogueo = 0;
            salirSistema = false;
            InitializeComponent();
        }

        private void LoginUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!salirSistema)
            {
                e.Cancel = true;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != String.Empty || txtUsuario.Text != String.Empty)
            {
                var resultado = Usuario.IngresarSistema(txtContraseña.Text, txtUsuario.Text);

                if (resultado == null)
                {
                    IntentosLogueo++;
                    pgbIntentos.Value = IntentosLogueo;
                    lblStatus.Text = "";
                    lblStatus3.Text = "";
                    lblStatus2.Text = "Datos Incorrectos";
                    lblintentos.Text = "Intentos " + " " + IntentosLogueo + " De 3";

                    txtContraseña.Text = String.Empty;
                    txtUsuario.Text = String.Empty;

                    if (IntentosLogueo == 3)
                    {
                        btnaceptar.Enabled = false;
                        lblStatus2.Text = "";
                        lblStatus3.Text = "";
                        lblStatus.Text = "Solo 3 intentos permitidos";
                    }
                }
                else
                {
                    Owner.Enabled = true;
                    Owner.Text = resultado.Nombre;
                    salirSistema = true;
                    this.Close();
                }
            }
            else
            {
                lblStatus.Text = "";
                lblStatus2.Text = "";
                lblStatus3.Text = "Contraseña y/o Usuario vacios";
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Owner.Dispose();
        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
