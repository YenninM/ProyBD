using System.Windows.Forms;

namespace ProyBD
{
    public partial class ReporteCarros : Form
    {
        public ReporteCarros()
        {
            InitializeComponent();
        }

        private void ReporteCarros_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'fmrdbDataSet.CARROS' table. You can move, or remove it, as needed.
            this.CARROSTableAdapter.Fill(this.fmrdbDataSet.CARROS);

            this.reportViewer1.RefreshReport();
        }
    }
}
