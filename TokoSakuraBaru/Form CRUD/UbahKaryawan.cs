using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSakuraBaru.Form_CRUD
{
    public partial class UbahKaryawan : Form
    {
        public UbahKaryawan()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Master.KelolaKaryawan kk = new Master.KelolaKaryawan();
            kk.Show();
        }
    }
}
