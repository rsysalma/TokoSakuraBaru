using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSakuraBaru.Transaksi
{
    public partial class PengadaanBarang : Form
    {
        public PengadaanBarang()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Gudang gdg = new Gudang();
            gdg.Show();
        }

        private void btnJenisBarang_Click(object sender, EventArgs e)
        {
            Master.KelolaJenisBarang kjb = new Master.KelolaJenisBarang();
            kjb.Show();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            Master.KelolaBarang kb = new Master.KelolaBarang();
            kb.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Master.KelolaSupplier ks = new Master.KelolaSupplier();
            ks.Show();
        }
    }
}
