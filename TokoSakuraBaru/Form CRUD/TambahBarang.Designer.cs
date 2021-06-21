namespace TokoSakuraBaru.Form_CRUD
{
    partial class TambahBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahBarang));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbJenisBarng = new System.Windows.Forms.ComboBox();
            this.errorSupplier = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorJenisBarang = new System.Windows.Forms.Label();
            this.errorNama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.errorDeskripsi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.errorHarga = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkSalmon;
            this.header.Controls.Add(this.bunifuImageButton3);
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.bunifuCustomLabel3);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 54);
            this.header.TabIndex = 133;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(9, 12);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 6;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(758, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Bisque;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 14);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(138, 19);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Tambah Barang";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSupplier);
            this.groupBox1.Controls.Add(this.cbJenisBarng);
            this.groupBox1.Controls.Add(this.errorSupplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.errorJenisBarang);
            this.groupBox1.Controls.Add(this.errorNama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 330);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Barang";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(22, 237);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(301, 29);
            this.cbSupplier.TabIndex = 19;
            // 
            // cbJenisBarng
            // 
            this.cbJenisBarng.FormattingEnabled = true;
            this.cbJenisBarng.Location = new System.Drawing.Point(23, 151);
            this.cbJenisBarng.Name = "cbJenisBarng";
            this.cbJenisBarng.Size = new System.Drawing.Size(301, 29);
            this.cbJenisBarng.TabIndex = 18;
            // 
            // errorSupplier
            // 
            this.errorSupplier.AutoSize = true;
            this.errorSupplier.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorSupplier.ForeColor = System.Drawing.Color.Tomato;
            this.errorSupplier.Location = new System.Drawing.Point(21, 266);
            this.errorSupplier.Name = "errorSupplier";
            this.errorSupplier.Size = new System.Drawing.Size(175, 17);
            this.errorSupplier.TabIndex = 16;
            this.errorSupplier.Text = "Supplier tidak boleh kosong.";
            this.errorSupplier.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(20, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Supplier";
            // 
            // errorJenisBarang
            // 
            this.errorJenisBarang.AutoSize = true;
            this.errorJenisBarang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorJenisBarang.ForeColor = System.Drawing.Color.Tomato;
            this.errorJenisBarang.Location = new System.Drawing.Point(20, 179);
            this.errorJenisBarang.Name = "errorJenisBarang";
            this.errorJenisBarang.Size = new System.Drawing.Size(200, 17);
            this.errorJenisBarang.TabIndex = 13;
            this.errorJenisBarang.Text = "Jenis Barang tidak boleh kosong.";
            this.errorJenisBarang.Visible = false;
            // 
            // errorNama
            // 
            this.errorNama.AutoSize = true;
            this.errorNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorNama.ForeColor = System.Drawing.Color.Tomato;
            this.errorNama.Location = new System.Drawing.Point(20, 97);
            this.errorNama.Name = "errorNama";
            this.errorNama.Size = new System.Drawing.Size(162, 17);
            this.errorNama.TabIndex = 11;
            this.errorNama.Text = "Nama tidak boleh kosong.";
            this.errorNama.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(19, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Jenis Barang";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNama.Location = new System.Drawing.Point(23, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(300, 27);
            this.txtNama.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama";
            // 
            // btnBatal
            // 
            this.btnBatal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnBatal.BackColor = System.Drawing.Color.White;
            this.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatal.BorderRadius = 0;
            this.btnBatal.ButtonText = "Batal";
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.DisabledColor = System.Drawing.Color.Gray;
            this.btnBatal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBatal.Iconimage = null;
            this.btnBatal.Iconimage_right = null;
            this.btnBatal.Iconimage_right_Selected = null;
            this.btnBatal.Iconimage_Selected = null;
            this.btnBatal.IconMarginLeft = 0;
            this.btnBatal.IconMarginRight = 0;
            this.btnBatal.IconRightVisible = true;
            this.btnBatal.IconRightZoom = 0D;
            this.btnBatal.IconVisible = true;
            this.btnBatal.IconZoom = 90D;
            this.btnBatal.IsTab = false;
            this.btnBatal.Location = new System.Drawing.Point(529, 424);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.White;
            this.btnBatal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(107, 32);
            this.btnBatal.TabIndex = 136;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBatal.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnBatal.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderRadius = 0;
            this.btnSimpan.ButtonText = "Simpan";
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DisabledColor = System.Drawing.Color.Gray;
            this.btnSimpan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSimpan.Iconimage = null;
            this.btnSimpan.Iconimage_right = null;
            this.btnSimpan.Iconimage_right_Selected = null;
            this.btnSimpan.Iconimage_Selected = null;
            this.btnSimpan.IconMarginLeft = 0;
            this.btnSimpan.IconMarginRight = 0;
            this.btnSimpan.IconRightVisible = true;
            this.btnSimpan.IconRightZoom = 0D;
            this.btnSimpan.IconVisible = true;
            this.btnSimpan.IconZoom = 90D;
            this.btnSimpan.IsTab = false;
            this.btnSimpan.Location = new System.Drawing.Point(663, 424);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(107, 32);
            this.btnSimpan.TabIndex = 135;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDeskripsi);
            this.groupBox2.Controls.Add(this.errorDeskripsi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.errorHarga);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(401, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 330);
            this.groupBox2.TabIndex = 137;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(44, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rp";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtDeskripsi.Location = new System.Drawing.Point(39, 153);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(300, 110);
            this.txtDeskripsi.TabIndex = 17;
            // 
            // errorDeskripsi
            // 
            this.errorDeskripsi.AutoSize = true;
            this.errorDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorDeskripsi.ForeColor = System.Drawing.Color.Tomato;
            this.errorDeskripsi.Location = new System.Drawing.Point(36, 266);
            this.errorDeskripsi.Name = "errorDeskripsi";
            this.errorDeskripsi.Size = new System.Drawing.Size(180, 17);
            this.errorDeskripsi.TabIndex = 16;
            this.errorDeskripsi.Text = "Deskripsi tidak boleh kosong.";
            this.errorDeskripsi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Deskripsi";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.textBox2.Location = new System.Drawing.Point(75, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 27);
            this.textBox2.TabIndex = 14;
            // 
            // errorHarga
            // 
            this.errorHarga.AutoSize = true;
            this.errorHarga.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorHarga.ForeColor = System.Drawing.Color.Tomato;
            this.errorHarga.Location = new System.Drawing.Point(36, 97);
            this.errorHarga.Name = "errorHarga";
            this.errorHarga.Size = new System.Drawing.Size(163, 17);
            this.errorHarga.TabIndex = 13;
            this.errorHarga.Text = "Harga tidak boleh kosong.";
            this.errorHarga.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label7.Location = new System.Drawing.Point(35, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Harga";
            // 
            // TambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TambahBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahBarang";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorJenisBarang;
        private System.Windows.Forms.Label errorNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private Bunifu.Framework.UI.BunifuFlatButton btnSimpan;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbJenisBarng;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label errorDeskripsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label errorHarga;
        private System.Windows.Forms.Label label7;
    }
}