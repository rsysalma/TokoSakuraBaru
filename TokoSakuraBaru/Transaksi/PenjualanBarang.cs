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
    public partial class PenjualanBarang : Form
    {
        public PenjualanBarang()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_CRUD.FormBayar fb = new Form_CRUD.FormBayar();
            fb.Show();
        }
    }
}
