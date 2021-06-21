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
    public partial class TambahHadiah : Form
    {
        public TambahHadiah()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Master.KelolaHadiah kh = new Master.KelolaHadiah();
            kh.Show();
        }
    }
}
