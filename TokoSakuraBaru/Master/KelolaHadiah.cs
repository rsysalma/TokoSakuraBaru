using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSakuraBaru.Master
{
    public partial class KelolaHadiah : Form
    {
        public KelolaHadiah()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Kasir ksr = new Kasir();
            ksr.Show();
        }

        private void btnJenisMember_Click(object sender, EventArgs e)
        {
            Master.KelolaJenisMember kjm = new Master.KelolaJenisMember();
            kjm.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Master.KelolaMember km = new Master.KelolaMember();
            km.Show();
        }

        private void btnPenukaranHadiah_Click(object sender, EventArgs e)
        {
            Transaksi.PenukaranHadiah ph = new Transaksi.PenukaranHadiah();
            ph.Show();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            Transaksi.PenjualanBarang pb = new Transaksi.PenjualanBarang();
            pb.Show();

        }

        private void btnPembuatanMember_Click(object sender, EventArgs e)
        {
            Transaksi.PembuatanMember pm = new Transaksi.PembuatanMember();
            pm.Show();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            Form_CRUD.UbahHadiah uh = new Form_CRUD.UbahHadiah();
            uh.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form_CRUD.TambahHadiah th = new Form_CRUD.TambahHadiah();
            th.Show();
        }
    }
}
