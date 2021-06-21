namespace TokoSakuraBaru.Form_CRUD
{
    partial class UbahGolonganKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahGolonganKaryawan));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCarii = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCari = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGaji = new System.Windows.Forms.TextBox();
            this.errorHarga = new System.Windows.Forms.Label();
            this.errorNama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUbah = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHapus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.header.Size = new System.Drawing.Size(426, 54);
            this.header.TabIndex = 137;
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
            this.btnClose.Location = new System.Drawing.Point(384, 12);
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
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(226, 19);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Ubah Golongan Karyawan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCarii);
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGaji);
            this.groupBox1.Controls.Add(this.errorHarga);
            this.groupBox1.Controls.Add(this.errorNama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 294);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Golongan Karyawan";
            // 
            // btnCarii
            // 
            this.btnCarii.Activecolor = System.Drawing.Color.White;
            this.btnCarii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarii.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCarii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarii.BorderRadius = 0;
            this.btnCarii.ButtonText = "Cari";
            this.btnCarii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarii.DisabledColor = System.Drawing.Color.Gray;
            this.btnCarii.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCarii.Iconimage = null;
            this.btnCarii.Iconimage_right = null;
            this.btnCarii.Iconimage_right_Selected = null;
            this.btnCarii.Iconimage_Selected = null;
            this.btnCarii.IconMarginLeft = 0;
            this.btnCarii.IconMarginRight = 0;
            this.btnCarii.IconRightVisible = true;
            this.btnCarii.IconRightZoom = 0D;
            this.btnCarii.IconVisible = true;
            this.btnCarii.IconZoom = 90D;
            this.btnCarii.IsTab = false;
            this.btnCarii.Location = new System.Drawing.Point(263, 77);
            this.btnCarii.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.btnCarii.Name = "btnCarii";
            this.btnCarii.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnCarii.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnCarii.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCarii.selected = false;
            this.btnCarii.Size = new System.Drawing.Size(63, 27);
            this.btnCarii.TabIndex = 131;
            this.btnCarii.Text = "Cari";
            this.btnCarii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCarii.Textcolor = System.Drawing.Color.White;
            this.btnCarii.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // btnCari
            // 
            this.btnCari.Activecolor = System.Drawing.Color.White;
            this.btnCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCari.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCari.BorderRadius = 0;
            this.btnCari.ButtonText = "Cari";
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.DisabledColor = System.Drawing.Color.Gray;
            this.btnCari.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCari.Iconimage = null;
            this.btnCari.Iconimage_right = null;
            this.btnCari.Iconimage_right_Selected = null;
            this.btnCari.Iconimage_Selected = null;
            this.btnCari.IconMarginLeft = 0;
            this.btnCari.IconMarginRight = 0;
            this.btnCari.IconRightVisible = true;
            this.btnCari.IconRightZoom = 0D;
            this.btnCari.IconVisible = true;
            this.btnCari.IconZoom = 90D;
            this.btnCari.IsTab = false;
            this.btnCari.Location = new System.Drawing.Point(410, 124);
            this.btnCari.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.btnCari.Name = "btnCari";
            this.btnCari.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnCari.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnCari.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCari.selected = false;
            this.btnCari.Size = new System.Drawing.Size(93, 44);
            this.btnCari.TabIndex = 130;
            this.btnCari.Text = "Cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCari.Textcolor = System.Drawing.Color.White;
            this.btnCari.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtID.Location = new System.Drawing.Point(24, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 27);
            this.txtID.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 128;
            this.label1.Text = "ID Golongan Karyawan";
            // 
            // txtGaji
            // 
            this.txtGaji.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtGaji.Location = new System.Drawing.Point(24, 221);
            this.txtGaji.Name = "txtGaji";
            this.txtGaji.Size = new System.Drawing.Size(311, 27);
            this.txtGaji.TabIndex = 14;
            // 
            // errorHarga
            // 
            this.errorHarga.AutoSize = true;
            this.errorHarga.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorHarga.ForeColor = System.Drawing.Color.Tomato;
            this.errorHarga.Location = new System.Drawing.Point(21, 251);
            this.errorHarga.Name = "errorHarga";
            this.errorHarga.Size = new System.Drawing.Size(149, 17);
            this.errorHarga.TabIndex = 13;
            this.errorHarga.Text = "Gaji tidak boleh kosong.";
            this.errorHarga.Visible = false;
            // 
            // errorNama
            // 
            this.errorNama.AutoSize = true;
            this.errorNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorNama.ForeColor = System.Drawing.Color.Tomato;
            this.errorNama.Location = new System.Drawing.Point(21, 169);
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
            this.label8.Location = new System.Drawing.Point(20, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gaji";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNama.Location = new System.Drawing.Point(24, 139);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(311, 27);
            this.txtNama.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(20, 117);
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
            this.btnBatal.Location = new System.Drawing.Point(160, 384);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.White;
            this.btnBatal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(94, 32);
            this.btnBatal.TabIndex = 140;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBatal.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnBatal.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // btnUbah
            // 
            this.btnUbah.Activecolor = System.Drawing.Color.White;
            this.btnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbah.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUbah.BorderRadius = 0;
            this.btnUbah.ButtonText = "Ubah";
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.DisabledColor = System.Drawing.Color.Gray;
            this.btnUbah.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUbah.Iconimage = null;
            this.btnUbah.Iconimage_right = null;
            this.btnUbah.Iconimage_right_Selected = null;
            this.btnUbah.Iconimage_Selected = null;
            this.btnUbah.IconMarginLeft = 0;
            this.btnUbah.IconMarginRight = 0;
            this.btnUbah.IconRightVisible = true;
            this.btnUbah.IconRightZoom = 0D;
            this.btnUbah.IconVisible = true;
            this.btnUbah.IconZoom = 90D;
            this.btnUbah.IsTab = false;
            this.btnUbah.Location = new System.Drawing.Point(284, 384);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnUbah.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnUbah.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUbah.selected = false;
            this.btnUbah.Size = new System.Drawing.Size(94, 32);
            this.btnUbah.TabIndex = 139;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUbah.Textcolor = System.Drawing.Color.White;
            this.btnUbah.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // btnHapus
            // 
            this.btnHapus.Activecolor = System.Drawing.Color.White;
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapus.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapus.BorderRadius = 0;
            this.btnHapus.ButtonText = "Hapus";
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapus.Iconimage = null;
            this.btnHapus.Iconimage_right = null;
            this.btnHapus.Iconimage_right_Selected = null;
            this.btnHapus.Iconimage_Selected = null;
            this.btnHapus.IconMarginLeft = 0;
            this.btnHapus.IconMarginRight = 0;
            this.btnHapus.IconRightVisible = true;
            this.btnHapus.IconRightZoom = 0D;
            this.btnHapus.IconVisible = true;
            this.btnHapus.IconZoom = 90D;
            this.btnHapus.IsTab = false;
            this.btnHapus.Location = new System.Drawing.Point(44, 384);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnHapus.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus.selected = false;
            this.btnHapus.Size = new System.Drawing.Size(83, 32);
            this.btnHapus.TabIndex = 141;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHapus.Textcolor = System.Drawing.Color.White;
            this.btnHapus.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // UbahGolonganKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.header);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUbah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbahGolonganKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbahGolonganKaryawan";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGaji;
        private System.Windows.Forms.Label errorHarga;
        private System.Windows.Forms.Label errorNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private Bunifu.Framework.UI.BunifuFlatButton btnUbah;
        private Bunifu.Framework.UI.BunifuFlatButton btnHapus;
        private Bunifu.Framework.UI.BunifuFlatButton btnCari;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCarii;
    }
}