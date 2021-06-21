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
    public partial class KelolaGolonganKaryawan : Form
    {
        public KelolaGolonganKaryawan()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Show();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            Master.KelolaKaryawan kk = new Master.KelolaKaryawan();
            kk.Show();
        }

        private void btnGolKaryawan_Click(object sender, EventArgs e)
        {

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan.LaporanPenjualan lpenj = new Laporan.LaporanPenjualan();
            lpenj.Show();
        }

        private void btnLaporanPengadaan_Click(object sender, EventArgs e)
        {
            Laporan.LaporanPengadaan lp = new Laporan.LaporanPengadaan();
            lp.Show();
        }

        private void btnLaba_Click(object sender, EventArgs e)
        {
            Laporan.LaporanLabaBersih llb = new Laporan.LaporanLabaBersih();
            llb.Show();
        }

        private void btnBarangKosong_Click(object sender, EventArgs e)
        {
            Laporan.LaporanBarangKosong lbk = new Laporan.LaporanBarangKosong();
            lbk.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form_CRUD.TambahGolonganKaryawan tgk = new Form_CRUD.TambahGolonganKaryawan();
            tgk.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            Form_CRUD.UbahGolonganKaryawan ubk = new Form_CRUD.UbahGolonganKaryawan();
            ubk.Show();
        }
    }
}
