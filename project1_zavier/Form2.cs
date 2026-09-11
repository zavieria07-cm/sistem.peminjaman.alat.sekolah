using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Text = "Data Peminjam";
            btnSimpan.Click += btnSimpan_Click;

            TampilData();
        }

        private void TampilData()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = "SELECT id_peminjam, nama_peminjam, kelas, no_hp FROM peminjam";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvPeminjam.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaPeminjam.Text.Trim() == "" ||
                txtKelas.Text.Trim() == "")
            {
                MessageBox.Show("Nama peminjam dan kelas wajib diisi!");
                return;
            }

            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = @"INSERT INTO peminjam
                                     (nama_peminjam, kelas, no_hp)
                                     VALUES
                                     (@nama, @kelas, @nohp)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtNamaPeminjam.Text.Trim());
                        cmd.Parameters.AddWithValue("@kelas", txtKelas.Text.Trim());
                        cmd.Parameters.AddWithValue("@nohp", txtNoHp.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data peminjam berhasil disimpan!");

                txtNamaPeminjam.Clear();
                txtKelas.Clear();
                txtNoHp.Clear();

                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNoHp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}