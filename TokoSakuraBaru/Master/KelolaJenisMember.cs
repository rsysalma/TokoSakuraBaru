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
    public partial class KelolaJenisMember : Form
    {
        public KelolaJenisMember()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Kasir ksr = new Kasir();
            ksr.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Master.KelolaMember km = new Master.KelolaMember();
            km.Show();
        }

        private void btnHadiah_Click(object sender, EventArgs e)
        {
            Master.KelolaHadiah kh = new KelolaHadiah();
            kh.Show();
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form_CRUD.TambahJenisMember tjm = new Form_CRUD.TambahJenisMember();
            tjm.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            Form_CRUD.UbahJenisMember ujm = new Form_CRUD.UbahJenisMember();
            ujm.Show();
        }
    }
}
