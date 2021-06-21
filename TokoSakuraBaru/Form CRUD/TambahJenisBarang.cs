using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TokoSakuraBaru.FormTambahdanHapus
{
    public partial class TambahJenisBarang : Form
    {
        public TambahJenisBarang()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Master.KelolaJenisBarang kjb = new Master.KelolaJenisBarang();
            kjb.Show();
        }

        public string GetConnectionDB()
        {
            //sekar
            //string ConnectionString = @"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=TokoSakura";
            // salma
            string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
            return connectionString;
        }

        public string autogenerateID(string firstText, string query)
        {
            string connectionString = GetConnectionDB();
            SqlCommand sqlCmd;
            SqlConnection sqlCon;
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(2, '0');
            return result;
        }

        private void clear()
        {
            txtNama.Clear();
            cbDetail.SelectedIndex = -1;
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private Boolean ValidationInput()
        {
            // Validasi Inputan Didalam Forms.
            if (txtNama.Text == "" || cbDetail.SelectedIndex == -1)
            {
                ShowError();
                return false;
            }

            return true;
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, "Nama Jenis Barang wajib diisi!");
                epWrong.SetError(txtNama, "");
            }
            else
            {
                epWarning.SetError(txtNama, "");
                epWrong.SetError(txtNama, "");
            }
        }

    

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || cbDetail.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_InputJenisBarang", connection);
                string query = "SELECT TOP 1 Kode_Jenis_Barang FROM JenisBarang ORDER BY Kode_Jenis_Barang DESC";
                string txtID = autogenerateID("JBG", query);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Jenis_Barang", txtID);
                insert.Parameters.AddWithValue("Nama_Jenis_Barang", txtNama.Text);
                insert.Parameters.AddWithValue("Detail_Jenis_Barang", cbDetail.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data, error: " + ex.Message);
                }
            }
        }

        private void ShowError()
        {
            // Menampilkan Error Jika Field Tidak Lengkap.
            errorNama.Visible = (txtNama.Text == "") ? true : false;
            errorDetail.Visible = (cbDetail.Text == "") ? true : false;
        }

        private void cbDetail_Leave(object sender, EventArgs e)
        {
            if (cbDetail.Text == "")
            {
                epWarning.SetError(cbDetail, "Detail wajib diisi!");
                epWrong.SetError(cbDetail, "");
            }
            else
            {
                epWarning.SetError(cbDetail, "");
                epWrong.SetError(cbDetail, "");
            }
        }
    }
}
