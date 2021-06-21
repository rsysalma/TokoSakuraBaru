namespace TokoSakuraBaru.Form_CRUD
{
    partial class UbahKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahKaryawan));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbGolonganKaryawan = new System.Windows.Forms.ComboBox();
            this.errorJenisBarang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.errorAlamat = new System.Windows.Forms.Label();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.errorNoTelp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUbah = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tglLahir = new Bunifu.Framework.UI.BunifuDatepicker();
            this.errorTglLahir = new System.Windows.Forms.Label();
            this.errorJenisKelamin = new System.Windows.Forms.Label();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorNama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCari = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHapus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.header.Size = new System.Drawing.Size(800, 54);
            this.header.TabIndex = 143;
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
            this.btnClose.Location = new System.Drawing.Point(740, 12);
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
            this.bunifuCustomLabel3.Text = "Ubah Karyawan";
            // 
            // cbGolonganKaryawan
            // 
            this.cbGolonganKaryawan.FormattingEnabled = true;
            this.cbGolonganKaryawan.Location = new System.Drawing.Point(28, 277);
            this.cbGolonganKaryawan.Name = "cbGolonganKaryawan";
            this.cbGolonganKaryawan.Size = new System.Drawing.Size(301, 29);
            this.cbGolonganKaryawan.TabIndex = 21;
            // 
            // errorJenisBarang
            // 
            this.errorJenisBarang.AutoSize = true;
            this.errorJenisBarang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorJenisBarang.ForeColor = System.Drawing.Color.Tomato;
            this.errorJenisBarang.Location = new System.Drawing.Point(25, 305);
            this.errorJenisBarang.Name = "errorJenisBarang";
            this.errorJenisBarang.Size = new System.Drawing.Size(211, 17);
            this.errorJenisBarang.TabIndex = 20;
            this.errorJenisBarang.Text = "Pilih salah satu golongan karyawan";
            this.errorJenisBarang.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGolonganKaryawan);
            this.groupBox2.Controls.Add(this.errorJenisBarang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAlamat);
            this.groupBox2.Controls.Add(this.errorAlamat);
            this.groupBox2.Controls.Add(this.txtNoTelp);
            this.groupBox2.Controls.Add(this.errorNoTelp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(401, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 330);
            this.groupBox2.TabIndex = 147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Karyawan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(24, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Golongan Karyawan";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtAlamat.Location = new System.Drawing.Point(29, 46);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(300, 86);
            this.txtAlamat.TabIndex = 17;
            // 
            // errorAlamat
            // 
            this.errorAlamat.AutoSize = true;
            this.errorAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorAlamat.ForeColor = System.Drawing.Color.Tomato;
            this.errorAlamat.Location = new System.Drawing.Point(25, 134);
            this.errorAlamat.Name = "errorAlamat";
            this.errorAlamat.Size = new System.Drawing.Size(167, 17);
            this.errorAlamat.TabIndex = 16;
            this.errorAlamat.Text = "Alamat tidak boleh kosong.";
            this.errorAlamat.Visible = false;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNoTelp.Location = new System.Drawing.Point(28, 190);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(300, 27);
            this.txtNoTelp.TabIndex = 14;
            // 
            // errorNoTelp
            // 
            this.errorNoTelp.AutoSize = true;
            this.errorNoTelp.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorNoTelp.ForeColor = System.Drawing.Color.Tomato;
            this.errorNoTelp.Location = new System.Drawing.Point(25, 219);
            this.errorNoTelp.Name = "errorNoTelp";
            this.errorNoTelp.Size = new System.Drawing.Size(139, 17);
            this.errorNoTelp.TabIndex = 13;
            this.errorNoTelp.Text = "No Telepon tidak valid";
            this.errorNoTelp.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label7.Location = new System.Drawing.Point(24, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "No Telepon";
            // 
            // btnBatal
            // 
            this.btnBatal.Activecolor = System.Drawing.Color.DarkSalmon;
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
            this.btnBatal.Location = new System.Drawing.Point(529, 420);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Normalcolor = System.Drawing.Color.White;
            this.btnBatal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnBatal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnBatal.selected = false;
            this.btnBatal.Size = new System.Drawing.Size(107, 32);
            this.btnBatal.TabIndex = 146;
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
            this.btnUbah.Location = new System.Drawing.Point(663, 420);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnUbah.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnUbah.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUbah.selected = false;
            this.btnUbah.Size = new System.Drawing.Size(107, 32);
            this.btnUbah.TabIndex = 145;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUbah.Textcolor = System.Drawing.Color.White;
            this.btnUbah.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // tglLahir
            // 
            this.tglLahir.BackColor = System.Drawing.Color.DarkSalmon;
            this.tglLahir.BorderRadius = 0;
            this.tglLahir.ForeColor = System.Drawing.Color.White;
            this.tglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglLahir.FormatCustom = null;
            this.tglLahir.Location = new System.Drawing.Point(22, 311);
            this.tglLahir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tglLahir.Name = "tglLahir";
            this.tglLahir.Size = new System.Drawing.Size(301, 29);
            this.tglLahir.TabIndex = 143;
            this.tglLahir.Value = new System.DateTime(2021, 6, 19, 14, 8, 35, 810);
            // 
            // errorTglLahir
            // 
            this.errorTglLahir.AutoSize = true;
            this.errorTglLahir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorTglLahir.ForeColor = System.Drawing.Color.Tomato;
            this.errorTglLahir.Location = new System.Drawing.Point(20, 345);
            this.errorTglLahir.Name = "errorTglLahir";
            this.errorTglLahir.Size = new System.Drawing.Size(199, 17);
            this.errorTglLahir.TabIndex = 23;
            this.errorTglLahir.Text = "Tanggal lahir tidak boleh kosong";
            this.errorTglLahir.Visible = false;
            // 
            // errorJenisKelamin
            // 
            this.errorJenisKelamin.AutoSize = true;
            this.errorJenisKelamin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorJenisKelamin.ForeColor = System.Drawing.Color.Tomato;
            this.errorJenisKelamin.Location = new System.Drawing.Point(20, 247);
            this.errorJenisKelamin.Name = "errorJenisKelamin";
            this.errorJenisKelamin.Size = new System.Drawing.Size(174, 17);
            this.errorJenisKelamin.TabIndex = 22;
            this.errorJenisKelamin.Text = "Pilih salah satu jenis kelamin.";
            this.errorJenisKelamin.Visible = false;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerempuan.Location = new System.Drawing.Point(166, 223);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(92, 21);
            this.rbPerempuan.TabIndex = 21;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLaki.Location = new System.Drawing.Point(33, 223);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(80, 21);
            this.rbLaki.TabIndex = 20;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki - laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(19, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama";
            // 
            // errorNama
            // 
            this.errorNama.AutoSize = true;
            this.errorNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.errorNama.ForeColor = System.Drawing.Color.Tomato;
            this.errorNama.Location = new System.Drawing.Point(20, 154);
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
            this.label8.Location = new System.Drawing.Point(19, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNama.Location = new System.Drawing.Point(23, 124);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(300, 27);
            this.txtNama.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tglLahir);
            this.groupBox1.Controls.Add(this.errorTglLahir);
            this.groupBox1.Controls.Add(this.errorJenisKelamin);
            this.groupBox1.Controls.Add(this.rbPerempuan);
            this.groupBox1.Controls.Add(this.rbLaki);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.errorNama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 385);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Karyawan";
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
            this.btnCari.Location = new System.Drawing.Point(263, 63);
            this.btnCari.Margin = new System.Windows.Forms.Padding(14, 21, 14, 21);
            this.btnCari.Name = "btnCari";
            this.btnCari.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnCari.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnCari.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCari.selected = false;
            this.btnCari.Size = new System.Drawing.Size(60, 27);
            this.btnCari.TabIndex = 147;
            this.btnCari.Text = "Cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCari.Textcolor = System.Drawing.Color.White;
            this.btnCari.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkSalmon;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cari";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(393, 109);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(14, 21, 14, 21);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(92, 44);
            this.bunifuFlatButton1.TabIndex = 146;
            this.bunifuFlatButton1.Text = "Cari";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtID.Location = new System.Drawing.Point(23, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 27);
            this.txtID.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(19, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 144;
            this.label5.Text = "ID Karyawan";
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
            this.btnHapus.Location = new System.Drawing.Point(396, 420);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnHapus.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapus.selected = false;
            this.btnHapus.Size = new System.Drawing.Size(107, 32);
            this.btnHapus.TabIndex = 148;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHapus.Textcolor = System.Drawing.Color.White;
            this.btnHapus.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // UbahKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.header);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbahKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbahKaryawan";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox cbGolonganKaryawan;
        private System.Windows.Forms.Label errorJenisBarang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label errorAlamat;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Label errorNoTelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnBatal;
        private Bunifu.Framework.UI.BunifuFlatButton btnUbah;
        private Bunifu.Framework.UI.BunifuDatepicker tglLahir;
        private System.Windows.Forms.Label errorTglLahir;
        private System.Windows.Forms.Label errorJenisKelamin;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHapus;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnCari;
    }
}