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

using ProyBD.DAO;

//using System.Data;
//using System.Data.SqlClient;

namespace ProyBD
{
    public partial class VerClientes : Form
    {
        ClientesTabla obje = new ClientesTabla();
        string palabra;

        public VerClientes()
        {
            InitializeComponent();
        }

       ConsultasSQL sql = new ConsultasSQL();

        private void CheckTxt()
        {

            palabra = palabra + txtIDcliente.Text;
            

        }

        private void btnSalirClientes2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var principal = new VentanaPrincipal();
            principal.Show();
        }

        private void btnSalirVerC_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formulario = new Clientes();
            formulario.Show();
        }

        private void btnAñadircliente2_Click(object sender, EventArgs e)
        {
            AñadirClientes f = new AñadirClientes();
            f.SetPrevForm(this);
            f.Show();
            this.Hide();
        }

        private void btnModificarcliente2_Click(object sender, EventArgs e)
        {
            ModificarCliente f = new ModificarCliente();
            f.SetPrevForm(this);
            f.Show();
            this.Hide();
        }

        private void btnEliminarcliente2_Click(object sender, EventArgs e)
        {
            EliminarCliente f = new EliminarCliente();
            f.SetPrevForm(this);
            f.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDcliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtColonia.Text = "";
            txtDireccion.Text = "";
            txtIDcliente.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
        }

        private void txtIDcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider2.SetError(this.txtIDcliente, "Caracter no admitido");
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider2.Clear();
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider3.SetError(this.txtTelefono, "Caracter no admitido");
            }

            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                errorProvider3.Clear();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider4.SetError(this.txtNombre, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar))
            {
                errorProvider4.Clear();
            }
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider5.SetError(this.txtColonia, "Caracter no admitido");
            }

            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
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
            if(Regex.IsMatch(txtCorreo.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtCorreo, "Correo no valido");
            }
        }

        private void gbxBuscar_Enter(object sender, EventArgs e)
        {

        }

       /* private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            txtIDcliente.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtDireccion.Text = Convert.ToString(fila.Cells[2].Value);
            txtColonia.Text = Convert.ToString(fila.Cells[3].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells[4].Value);
        }*/


        private void VerClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.VistaTabla();
            
            //dataGridView1.DataSource = llenar_grid();


            //dgvClientes.DataSource = sql.MostrarDatos();
        }
        /*
        public DataTable llenar_grid()
        {
            ConsultasSQL.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM CLIENTES";
            SqlCommand cmd = new SqlCommand(consulta, ConsultasSQL.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }*/
    }
}
