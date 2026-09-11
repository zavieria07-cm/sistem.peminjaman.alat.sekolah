
namespace project1_ridho
{
    partial class FormPenduduk
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
            this.txtKodeAlat = new System.Windows.Forms.TextBox();
            this.txtNamaAlat = new System.Windows.Forms.TextBox();
            this.cmbKondisi = new System.Windows.Forms.ComboBox();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            this.cmbJumlah = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAlat = new System.Windows.Forms.DataGridView();
            this.btnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKodeAlat
            // 
            this.txtKodeAlat.Location = new System.Drawing.Point(126, 90);
            this.txtKodeAlat.Name = "txtKodeAlat";
            this.txtKodeAlat.Size = new System.Drawing.Size(165, 20);
            this.txtKodeAlat.TabIndex = 0;
            // 
            // txtNamaAlat
            // 
            this.txtNamaAlat.Location = new System.Drawing.Point(126, 116);
            this.txtNamaAlat.Name = "txtNamaAlat";
            this.txtNamaAlat.Size = new System.Drawing.Size(165, 20);
            this.txtNamaAlat.TabIndex = 1;
            // 
            // cmbKondisi
            // 
            this.cmbKondisi.FormattingEnabled = true;
            this.cmbKondisi.Items.AddRange(new object[] {
            "Baik",
            "Rusak Ringan",
            "Rusak Berat"});
            this.cmbKondisi.Location = new System.Drawing.Point(126, 168);
            this.cmbKondisi.Name = "cmbKondisi";
            this.cmbKondisi.Size = new System.Drawing.Size(165, 21);
            this.cmbKondisi.TabIndex = 2;
            // 
            // txtLokasi
            // 
            this.txtLokasi.Location = new System.Drawing.Point(126, 195);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.Size = new System.Drawing.Size(165, 20);
            this.txtLokasi.TabIndex = 3;
            this.txtLokasi.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // cmbJumlah
            // 
            this.cmbJumlah.FormattingEnabled = true;
            this.cmbJumlah.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbJumlah.Location = new System.Drawing.Point(126, 141);
            this.cmbJumlah.Name = "cmbJumlah";
            this.cmbJumlah.Size = new System.Drawing.Size(165, 21);
            this.cmbJumlah.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(170, 222);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kode alat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama alat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lokasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kondisi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jumlah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATA ALAT SEKOLAH";
            // 
            // dgvAlat
            // 
            this.dgvAlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlat.Location = new System.Drawing.Point(-1, 269);
            this.dgvAlat.Name = "dgvAlat";
            this.dgvAlat.Size = new System.Drawing.Size(802, 169);
            this.dgvAlat.TabIndex = 13;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(463, 184);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 14;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormPenduduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.dgvAlat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbJumlah);
            this.Controls.Add(this.txtLokasi);
            this.Controls.Add(this.cmbKondisi);
            this.Controls.Add(this.txtNamaAlat);
            this.Controls.Add(this.txtKodeAlat);
            this.Name = "FormPenduduk";
            this.Text = "DataAlatSekolah";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKodeAlat;
        private System.Windows.Forms.TextBox txtNamaAlat;
        private System.Windows.Forms.ComboBox cmbKondisi;
        private System.Windows.Forms.TextBox txtLokasi;
        private System.Windows.Forms.ComboBox cmbJumlah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAlat;
        private System.Windows.Forms.Button btnKeluar;
    }
}