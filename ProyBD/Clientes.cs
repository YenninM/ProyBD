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
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();

        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            var formulario = new VerClientes();
            formulario.Show();
            this.Hide();
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadirclientes_Click(object sender, EventArgs e)
        {
            AñadirClientes f = new AñadirClientes();
            f.SetPrevForm(this);
            f.Show();
            this.Hide();
        }

        private void btnModificarcliente_Click(object sender, EventArgs e)
        {
            ModificarCliente f = new ModificarCliente();
            f.SetPrevForm(this);
            f.Show();
            this.Hide();
        }

        private void btnEliminarcliente_Click(object sender, EventArgs e)
        {
            EliminarCliente f = new EliminarCliente();
            f.SetPrevForm(this);
            f.Show();
            this.Hide();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void Clientes_TextChanged(object sender, EventArgs e)
        {
            var nombre = this.Text;
            var resultado = Usuario.BuscarPorNombre(nombre);

            lblUsuario.Text = resultado.Nombre;

            if (lblUsuario.Text.Contains("admin"))
            {
                btnVerClientes.Enabled = true;
                btnAñadirclientes.Enabled = true;
                btnModificarcliente.Enabled = true;
                btnEliminarcliente.Enabled = true;
            }
            else
            {
                btnVerClientes.Enabled = true;
                btnAñadirclientes.Enabled = true;
                btnModificarcliente.Enabled = false;
                btnEliminarcliente.Enabled = false;
            }
        }
    }
}
