using System;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BuscarRacasMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBuscarRacas().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Miau!");
        }
    }
}
