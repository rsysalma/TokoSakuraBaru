using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSakuraBaru
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Size = new Size(504, 585);
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            HalamanAwal ha = new HalamanAwal();
            ha.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
