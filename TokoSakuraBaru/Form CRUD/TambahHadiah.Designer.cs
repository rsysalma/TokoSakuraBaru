namespace TokoSakuraBaru.Form_CRUD
{
    partial class TambahHadiah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahHadiah));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPoin = new System.Windows.Forms.TextBox();
            this.errorPoin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.errorJumlah = new System.Windows.Forms.Label();
            this.errorNama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.header.Size = new System.Drawing.Size(441, 54);
            this.header.TabIndex = 125;
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
            this.btnClose.Location = new System.Drawing.Point(376, 12);
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
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(139, 19);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Tambah Hadiah";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPoin);
            this.groupBox1.Controls.Add(this.errorPoin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtJumlah);
            this.groupBox1.Controls.Add(this.errorJumlah);
            this.groupBox1.Controls.Add(this.errorNama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 330);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Hadiah";
            // 
            // txtPoin
            // 
            this.txtPoin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtPoin.Location = new System.Drawing.Point(39, 248);
            this.txtPoin.Name = "txtPoin";
            this.txtPoin.Size = new System.Drawing.Size(300, 27);
            this.txtPoin.TabIndex = 17;
            // 
            // errorPoin
            // 
            this.errorPoin.AutoSize = true;
            this.errorPoin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorPoin.ForeColor = System.Drawing.Color.Tomato;
            this.errorPoin.Location = new System.Drawing.Point(36, 278);
            this.errorPoin.Name = "errorPoin";
            this.errorPoin.Size = new System.Drawing.Size(152, 17);
            this.errorPoin.TabIndex = 16;
            this.errorPoin.Text = "Poin tidak boleh kosong.";
            this.errorPoin.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(35, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Poin";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtJumlah.Location = new System.Drawing.Point(38, 161);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(300, 27);
            this.txtJumlah.TabIndex = 14;
            // 
            // errorJumlah
            // 
            this.errorJumlah.AutoSize = true;
            this.errorJumlah.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorJumlah.ForeColor = System.Drawing.Color.Tomato;
            this.errorJumlah.Location = new System.Drawing.Point(35, 191);
            this.errorJumlah.Name = "errorJumlah";
            this.errorJumlah.Size = new System.Drawing.Size(167, 17);
            this.errorJumlah.TabIndex = 13;
            this.errorJumlah.Text = "Jumlah tidak boleh kosong.";
            this.errorJumlah.Visible = false;
            // 
            // errorNama
            // 
            this.errorNama.AutoSize = true;
            this.errorNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorNama.ForeColor = System.Drawing.Color.Tomato;
            this.errorNama.Location = new System.Drawing.Point(35, 109);
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
            this.label8.Location = new System.Drawing.Point(34, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Jumlah";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNama.Location = new System.Drawing.Point(38, 79);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(300, 27);
            this.txtNama.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(34, 57);
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
            this.btnBatal.Location = new System.Drawing.Point(144, 430);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.White;
            this.btnBatal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(107, 32);
            this.btnBatal.TabIndex = 128;
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
            this.btnSimpan.Location = new System.Drawing.Point(283, 430);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnSimpan.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(107, 32);
            this.btnSimpan.TabIndex = 127;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // TambahHadiah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(441, 486);
            this.Controls.Add(this.header);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TambahHadiah";
            this.Text = "TambahHadiah";
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
        private System.Windows.Forms.TextBox txtPoin;
        private System.Windows.Forms.Label errorPoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label errorJumlah;
        private System.Windows.Forms.Label errorNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private Bunifu.Framework.UI.BunifuFlatButton btnSimpan;
    }
}