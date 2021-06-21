namespace TokoSakuraBaru.Form_CRUD
{
    partial class FormBayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBayar));
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKembali = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCetakStruk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkSalmon;
            this.header.Controls.Add(this.bunifuImageButton3);
            this.header.Controls.Add(this.bunifuCustomLabel3);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(344, 54);
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
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Bisque;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 14);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(115, 19);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Pembayaran";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 264);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Pembayaran";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.txtNama.Location = new System.Drawing.Point(67, 69);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(193, 27);
            this.txtNama.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Harga";
            // 
            // btnKembali
            // 
            this.btnKembali.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnKembali.BackColor = System.Drawing.Color.White;
            this.btnKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKembali.BorderRadius = 0;
            this.btnKembali.ButtonText = "Kembali";
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali.DisabledColor = System.Drawing.Color.Gray;
            this.btnKembali.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKembali.Iconimage = null;
            this.btnKembali.Iconimage_right = null;
            this.btnKembali.Iconimage_right_Selected = null;
            this.btnKembali.Iconimage_Selected = null;
            this.btnKembali.IconMarginLeft = 0;
            this.btnKembali.IconMarginRight = 0;
            this.btnKembali.IconRightVisible = true;
            this.btnKembali.IconRightZoom = 0D;
            this.btnKembali.IconVisible = true;
            this.btnKembali.IconZoom = 90D;
            this.btnKembali.IsTab = false;
            this.btnKembali.Location = new System.Drawing.Point(36, 367);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Normalcolor = System.Drawing.Color.White;
            this.btnKembali.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnKembali.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnKembali.selected = false;
            this.btnKembali.Size = new System.Drawing.Size(107, 32);
            this.btnKembali.TabIndex = 140;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKembali.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnKembali.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // btnCetakStruk
            // 
            this.btnCetakStruk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnCetakStruk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCetakStruk.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCetakStruk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCetakStruk.BorderRadius = 0;
            this.btnCetakStruk.ButtonText = "Cetak Struk";
            this.btnCetakStruk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetakStruk.DisabledColor = System.Drawing.Color.Gray;
            this.btnCetakStruk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCetakStruk.Iconimage = null;
            this.btnCetakStruk.Iconimage_right = null;
            this.btnCetakStruk.Iconimage_right_Selected = null;
            this.btnCetakStruk.Iconimage_Selected = null;
            this.btnCetakStruk.IconMarginLeft = 0;
            this.btnCetakStruk.IconMarginRight = 0;
            this.btnCetakStruk.IconRightVisible = true;
            this.btnCetakStruk.IconRightZoom = 0D;
            this.btnCetakStruk.IconVisible = true;
            this.btnCetakStruk.IconZoom = 90D;
            this.btnCetakStruk.IsTab = false;
            this.btnCetakStruk.Location = new System.Drawing.Point(184, 367);
            this.btnCetakStruk.Name = "btnCetakStruk";
            this.btnCetakStruk.Normalcolor = System.Drawing.Color.DarkSalmon;
            this.btnCetakStruk.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnCetakStruk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCetakStruk.selected = false;
            this.btnCetakStruk.Size = new System.Drawing.Size(107, 32);
            this.btnCetakStruk.TabIndex = 139;
            this.btnCetakStruk.Text = "Cetak Struk";
            this.btnCetakStruk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCetakStruk.Textcolor = System.Drawing.Color.White;
            this.btnCetakStruk.TextFont = new System.Drawing.Font("Segoe UI", 10.75F);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label9.Location = new System.Drawing.Point(29, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(29, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rp";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.textBox1.Location = new System.Drawing.Point(67, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 27);
            this.textBox1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(29, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rp";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.textBox2.Location = new System.Drawing.Point(67, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 27);
            this.textBox2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(16, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kembalian";
            // 
            // FormBayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(344, 413);
            this.Controls.Add(this.header);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnCetakStruk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBayar";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnKembali;
        private Bunifu.Framework.UI.BunifuFlatButton btnCetakStruk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}