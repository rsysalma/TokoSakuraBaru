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
    public partial class KelolaBarang : Form
    {
        public KelolaBarang()
        {
            InitializeComponent();
        }

        private void KelolaBarang_Load(object sender, EventArgs e)
        {
           

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
          
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Master.KelolaSupplier ks = new Master.KelolaSupplier();
            ks.Show();
        }

        private void btnPengadaanBarang_Click(object sender, EventArgs e)
        {
            Transaksi.PengadaanBarang pb = new Transaksi.PengadaanBarang();
            pb.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form_CRUD.TambahBarang tb = new Form_CRUD.TambahBarang();
            tb.Show();


        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            Form_CRUD.UbahBarang ub = new Form_CRUD.UbahBarang();
            ub.Show();
        }
    }
}
