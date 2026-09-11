
namespace project1_ridho
{
    partial class FormPeminjaman
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPeminjam = new System.Windows.Forms.ComboBox();
            this.cmbAlat = new System.Windows.Forms.ComboBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.dtpTanggalPinjam = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalKembali = new System.Windows.Forms.DateTimePicker();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvPeminjaman = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peminjam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Pinjam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tagnggal Kembali";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Catatan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DATA PEMINJAMAN ALAT";
            // 
            // cmbPeminjam
            // 
            this.cmbPeminjam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeminjam.FormattingEnabled = true;
            this.cmbPeminjam.Location = new System.Drawing.Point(122, 38);
            this.cmbPeminjam.Name = "cmbPeminjam";
            this.cmbPeminjam.Size = new System.Drawing.Size(200, 21);
            this.cmbPeminjam.TabIndex = 7;
            // 
            // cmbAlat
            // 
            this.cmbAlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlat.FormattingEnabled = true;
            this.cmbAlat.Location = new System.Drawing.Point(122, 68);
            this.cmbAlat.Name = "cmbAlat";
            this.cmbAlat.Size = new System.Drawing.Size(200, 21);
            this.cmbAlat.TabIndex = 8;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(122, 95);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(200, 20);
            this.txtJumlah.TabIndex = 9;
            // 
            // dtpTanggalPinjam
            // 
            this.dtpTanggalPinjam.Location = new System.Drawing.Point(122, 121);
            this.dtpTanggalPinjam.Name = "dtpTanggalPinjam";
            this.dtpTanggalPinjam.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalPinjam.TabIndex = 10;
            // 
            // dtpTanggalKembali
            // 
            this.dtpTanggalKembali.Location = new System.Drawing.Point(122, 147);
            this.dtpTanggalKembali.Name = "dtpTanggalKembali";
            this.dtpTanggalKembali.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalKembali.TabIndex = 11;
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(122, 174);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(200, 20);
            this.txtCatatan.TabIndex = 12;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(122, 200);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dgvPeminjaman
            // 
            this.dgvPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjaman.Location = new System.Drawing.Point(-4, 242);
            this.dgvPeminjaman.Name = "dgvPeminjaman";
            this.dgvPeminjaman.Size = new System.Drawing.Size(719, 150);
            this.dgvPeminjaman.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(427, 174);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvPeminjaman);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtCatatan);
            this.Controls.Add(this.dtpTanggalKembali);
            this.Controls.Add(this.dtpTanggalPinjam);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.cmbAlat);
            this.Controls.Add(this.cmbPeminjam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPeminjaman";
            this.Text = "FormPeminjaman";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPeminjam;
        private System.Windows.Forms.ComboBox cmbAlat;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.DateTimePicker dtpTanggalPinjam;
        private System.Windows.Forms.DateTimePicker dtpTanggalKembali;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvPeminjaman;
        private System.Windows.Forms.Button btnLogout;
    }
}