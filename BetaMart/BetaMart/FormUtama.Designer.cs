namespace BetaMart
{
    partial class FormUtama
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
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.lbcari = new System.Windows.Forms.Label();
            this.tbcari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbkode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbtanggalmasuk = new System.Windows.Forms.DateTimePicker();
            this.btntampilkan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnedit.Location = new System.Drawing.Point(511, 406);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(154, 52);
            this.btnedit.TabIndex = 16;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.IndianRed;
            this.btnhapus.Location = new System.Drawing.Point(511, 462);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(154, 51);
            this.btnhapus.TabIndex = 15;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.SandyBrown;
            this.btntambah.Location = new System.Drawing.Point(511, 349);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(154, 51);
            this.btntambah.TabIndex = 14;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // lbcari
            // 
            this.lbcari.AutoSize = true;
            this.lbcari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcari.ForeColor = System.Drawing.Color.White;
            this.lbcari.Location = new System.Drawing.Point(189, 30);
            this.lbcari.Name = "lbcari";
            this.lbcari.Size = new System.Drawing.Size(43, 24);
            this.lbcari.TabIndex = 17;
            this.lbcari.Text = "Cari";
            this.lbcari.Click += new System.EventHandler(this.lbcari_Click);
            // 
            // tbcari
            // 
            this.tbcari.Location = new System.Drawing.Point(238, 30);
            this.tbcari.Multiline = true;
            this.tbcari.Name = "tbcari";
            this.tbcari.Size = new System.Drawing.Size(292, 26);
            this.tbcari.TabIndex = 18;
            this.tbcari.TextChanged += new System.EventHandler(this.tbcari_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 193);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("London Calling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 59);
            this.label1.TabIndex = 20;
            this.label1.Text = "BetaMart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Stok";
            // 
            // tbstok
            // 
            this.tbstok.Location = new System.Drawing.Point(187, 483);
            this.tbstok.Multiline = true;
            this.tbstok.Name = "tbstok";
            this.tbstok.Size = new System.Drawing.Size(297, 30);
            this.tbstok.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Harga";
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(187, 434);
            this.tbharga.Multiline = true;
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(297, 30);
            this.tbharga.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kode";
            // 
            // tbkode
            // 
            this.tbkode.Location = new System.Drawing.Point(187, 386);
            this.tbkode.Multiline = true;
            this.tbkode.Name = "tbkode";
            this.tbkode.Size = new System.Drawing.Size(297, 30);
            this.tbkode.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nama";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(187, 339);
            this.tbnama.Multiline = true;
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(297, 30);
            this.tbnama.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(187, 296);
            this.tbid.Multiline = true;
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(297, 30);
            this.tbid.TabIndex = 31;
            // 
            // tbtanggalmasuk
            // 
            this.tbtanggalmasuk.Location = new System.Drawing.Point(536, 30);
            this.tbtanggalmasuk.Name = "tbtanggalmasuk";
            this.tbtanggalmasuk.Size = new System.Drawing.Size(129, 20);
            this.tbtanggalmasuk.TabIndex = 33;
            // 
            // btntampilkan
            // 
            this.btntampilkan.BackColor = System.Drawing.Color.SandyBrown;
            this.btntampilkan.Location = new System.Drawing.Point(511, 294);
            this.btntampilkan.Name = "btntampilkan";
            this.btntampilkan.Size = new System.Drawing.Size(154, 49);
            this.btntampilkan.TabIndex = 34;
            this.btntampilkan.Text = "Tampilkan";
            this.btntampilkan.UseVisualStyleBackColor = false;
            this.btntampilkan.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 532);
            this.Controls.Add(this.btntampilkan);
            this.Controls.Add(this.tbtanggalmasuk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbkode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbcari);
            this.Controls.Add(this.lbcari);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btntambah);
            this.Name = "FormUtama";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Utama";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Label lbcari;
        private System.Windows.Forms.TextBox tbcari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbkode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.DateTimePicker tbtanggalmasuk;
        private System.Windows.Forms.Button btntampilkan;
    }
}