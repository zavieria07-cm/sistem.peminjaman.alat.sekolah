using System;
using System.Windows.Forms;

namespace project1_ridho
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormMain_Load);

            // Event Klik Tombol Utama
            this.btnDataRole.Click += (s, e) => new FormRole().ShowDialog();
            this.btnDataUser.Click += (s, e) => new FormUser().ShowDialog();
            this.btnDataPenduduk.Click += new EventHandler(this.btnDataPenduduk_Click);
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string role = Form1.RoleLoggedIn.Trim().ToLower();

            // Reset awal
            btnDataRole.Enabled = false;
            btnDataUser.Enabled = false;
            btnDataPenduduk.Enabled = false;

            if (role.Contains("admin"))
            {
                btnDataRole.Enabled = true;
                btnDataUser.Enabled = true;
                btnDataPenduduk.Enabled = true;
            }
            else if (role.Contains("petugas"))
            {
                btnDataRole.Enabled = false;
                btnDataUser.Enabled = true;
                btnDataPenduduk.Enabled = true;
            }
        }

        private void btnDataPenduduk_Click(object sender, EventArgs e)
        {
            // Admin / Petugas -> Buka Data Alat
            FormPenduduk alat = new FormPenduduk();
            alat.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                this.Hide();

                Form1 login = new Form1();
                login.ShowDialog();

                this.Close();
            }
        }

        private void btnDataRole_Click(object sender, EventArgs e)
        {
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
        }

        private void btnDataPenduduk_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buka Approval Peminjaman
            FormApproval form = new FormApproval();
            form.ShowDialog();
        }

        private void btnDataPeminjam_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void btnDataPeminjaman_Click(object sender, EventArgs e)
        {
            FormPeminjaman form = new FormPeminjaman();
            form.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}