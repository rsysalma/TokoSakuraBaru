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
    public partial class KelolaSupplier : Form
    {
        public KelolaSupplier()
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

        private void btnPengadaanBarang_Click(object sender, EventArgs e)
        {
            Transaksi.PengadaanBarang pb = new Transaksi.PengadaanBarang();
            pb.Show();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            Form_CRUD.UbahSupplier us = new Form_CRUD.UbahSupplier();
            us.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form_CRUD.TambahSupplier ts = new Form_CRUD.TambahSupplier();
            ts.Show();
        }
    }
}
