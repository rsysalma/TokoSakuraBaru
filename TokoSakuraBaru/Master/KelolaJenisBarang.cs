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
    public partial class KelolaJenisBarang : Form
    {
        public KelolaJenisBarang()
        {
            InitializeComponent();
        }

        private void KelolaJenisBarang_Load(object sender, EventArgs e)
        {
        
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Gudang gdg = new Gudang();
            gdg.Show();
        }

        private void btnJenisBarang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            KelolaBarang kb = new KelolaBarang();
            kb.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            KelolaSupplier ks = new KelolaSupplier();
            ks.Show();
        }

        private void btnPengadaanBarang_Click(object sender, EventArgs e)
        {
            Transaksi.PengadaanBarang pb = new Transaksi.PengadaanBarang();
            pb.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_CRUD.UbahJenisBarang ujb = new Form_CRUD.UbahJenisBarang();
            ujb.Show();
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            FormTambahdanHapus.TambahJenisBarang tjb = new FormTambahdanHapus.TambahJenisBarang();
            tjb.Show();
        }
    }
}
