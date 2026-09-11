
namespace project1_ridho
{
    partial class FormMain
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
            this.btnDataUser = new System.Windows.Forms.Button();
            this.btnDataRole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDataPenduduk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDataPeminjam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDataPeminjaman = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDataUser
            // 
            this.btnDataUser.Location = new System.Drawing.Point(17, 110);
            this.btnDataUser.Name = "btnDataUser";
            this.btnDataUser.Size = new System.Drawing.Size(148, 24);
            this.btnDataUser.TabIndex = 3;
            this.btnDataUser.Text = "Data User / Petugas";
            this.btnDataUser.UseVisualStyleBackColor = true;
            this.btnDataUser.Click += new System.EventHandler(this.btnDataUser_Click);
            // 
            // btnDataRole
            // 
            this.btnDataRole.Location = new System.Drawing.Point(17, 81);
            this.btnDataRole.Name = "btnDataRole";
            this.btnDataRole.Size = new System.Drawing.Size(148, 24);
            this.btnDataRole.TabIndex = 2;
            this.btnDataRole.Text = "Data Role";
            this.btnDataRole.UseVisualStyleBackColor = true;
            this.btnDataRole.Click += new System.EventHandler(this.btnDataRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selamat Datang di Menu Utama Sistem Peminjaman Alat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEM INFORMASI PEMINJAMAN ALAT SEKOLAH";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(17, 273);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnDataPenduduk
            // 
            this.btnDataPenduduk.Location = new System.Drawing.Point(17, 139);
            this.btnDataPenduduk.Name = "btnDataPenduduk";
            this.btnDataPenduduk.Size = new System.Drawing.Size(148, 24);
            this.btnDataPenduduk.TabIndex = 4;
            this.btnDataPenduduk.Text = "Data Alat";
            this.btnDataPenduduk.UseVisualStyleBackColor = true;
            this.btnDataPenduduk.Click += new System.EventHandler(this.btnDataPenduduk_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDataPeminjaman);
            this.panel1.Controls.Add(this.btnDataPeminjam);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDataPenduduk);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDataRole);
            this.panel1.Controls.Add(this.btnDataUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 450);
            this.panel1.TabIndex = 7;
            // 
            // btnDataPeminjam
            // 
            this.btnDataPeminjam.Location = new System.Drawing.Point(17, 169);
            this.btnDataPeminjam.Name = "btnDataPeminjam";
            this.btnDataPeminjam.Size = new System.Drawing.Size(148, 24);
            this.btnDataPeminjam.TabIndex = 7;
            this.btnDataPeminjam.Text = "Data Peminjam";
            this.btnDataPeminjam.UseVisualStyleBackColor = true;
            this.btnDataPeminjam.Click += new System.EventHandler(this.btnDataPeminjam_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Approval Peminjaman";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDataPeminjaman
            // 
            this.btnDataPeminjaman.Location = new System.Drawing.Point(17, 199);
            this.btnDataPeminjaman.Name = "btnDataPeminjaman";
            this.btnDataPeminjaman.Size = new System.Drawing.Size(148, 23);
            this.btnDataPeminjaman.TabIndex = 8;
            this.btnDataPeminjaman.Text = "Data Peminjaman";
            this.btnDataPeminjaman.UseVisualStyleBackColor = true;
            this.btnDataPeminjaman.Click += new System.EventHandler(this.btnDataPeminjaman_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataUser;
        private System.Windows.Forms.Button btnDataRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDataPenduduk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDataPeminjam;
        private System.Windows.Forms.Button btnDataPeminjaman;
    }
}