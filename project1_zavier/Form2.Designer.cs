
namespace project1_ridho
{
    partial class Form2
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
            this.txtNamaPeminjam = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvPeminjam = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama peminjam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. HP";
            // 
            // txtNamaPeminjam
            // 
            this.txtNamaPeminjam.Location = new System.Drawing.Point(135, 42);
            this.txtNamaPeminjam.Name = "txtNamaPeminjam";
            this.txtNamaPeminjam.Size = new System.Drawing.Size(127, 20);
            this.txtNamaPeminjam.TabIndex = 3;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(135, 71);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(127, 20);
            this.txtKelas.TabIndex = 4;
            // 
            // txtNoHp
            // 
            this.txtNoHp.Location = new System.Drawing.Point(135, 100);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(127, 20);
            this.txtNoHp.TabIndex = 5;
            this.txtNoHp.TextChanged += new System.EventHandler(this.txtNoHp_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(135, 126);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // dgvPeminjam
            // 
            this.dgvPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjam.Location = new System.Drawing.Point(1, 198);
            this.dgvPeminjam.Name = "dgvPeminjam";
            this.dgvPeminjam.Size = new System.Drawing.Size(712, 150);
            this.dgvPeminjam.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(502, 126);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 15;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 340);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPeminjam);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNamaPeminjam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPeminjam;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvPeminjam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKeluar;
    }
}