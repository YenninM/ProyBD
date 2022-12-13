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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            
            if (Application.OpenForms.Count == 1)
            {
                clientes.Show();
            }
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Visible = false;
            var login = new LoginUsuario() { Owner = this };
            this.Enabled = true;
            login.Show();

            btnClientes.Enabled = false;
            btnRecibo.Enabled = false;
            btnAutos.Enabled = false;
            btnSalir.Enabled = false;
            btnDeslogueo.Enabled = false;

        }

        private void VentanaPrincipal_TextChanged(object sender, EventArgs e)
        {
            lblUsuario.Visible = true;
            var nombre = this.Text;

            var resultado = Usuario.BuscarPorNombre(nombre);

            lblUsuario.Text = resultado.Nombre;

            if (lblUsuario.Text.Contains("admin"))
            {
                btnClientes.Enabled = true;
                btnRecibo.Enabled = true;
                btnAutos.Enabled = true;
                btnSalir.Enabled = true;
                btnDeslogueo.Enabled = true;
            }
            else
            {
                btnClientes.Enabled = true;
                btnRecibo.Enabled = true;
                btnAutos.Enabled = true;
                btnSalir.Enabled = true;
                btnDeslogueo.Enabled = true;
            }
        }

        private void btnDeslogueo_Click(object sender, EventArgs e)
        {
            var deslogin = new LoginUsuario() { Owner = this };
            this.Enabled = true;

            if (Application.OpenForms.Count == 1)
            {
                deslogin.Show();
            }  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            var carros = new Autos();
            if (Application.OpenForms.Count == 1)
            {
                carros.Show();
            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            var recibo = new Recibos();

            if (Application.OpenForms.Count == 1)
            {
                recibo.Show();
            }
        }

        private void cliente_btn_Click(object sender, EventArgs e)
        {
            var reporteClientes = new ReporteClientes();

            if (Application.OpenForms.Count == 1)
            {
                reporteClientes.Show();
            }
        }

        private void carros_btn_Click(object sender, EventArgs e)
        {
            var reporteCarros = new ReporteCarros();

            if (Application.OpenForms.Count == 1)
            {
                reporteCarros.Show();
            }
        }
    }
}
