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
    public partial class AñadirClientes : Form
    {
        public AñadirClientes()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var formulario = new VerClientes();
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Añadido");
        }
    }
}
