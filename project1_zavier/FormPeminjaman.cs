using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormPeminjaman : Form
    {
        public FormPeminjaman()
        {
            InitializeComponent();

            this.Text = "Data Peminjaman Alat";

            TampilPeminjam();
            TampilAlat();
            TampilDataPeminjaman();
        }

        // Menampilkan data peminjam ke ComboBox
        private void TampilPeminjam()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = "SELECT id_peminjam, nama_peminjam FROM peminjam";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbPeminjam.Items.Clear();

                        while (reader.Read())
                        {
                            cmbPeminjam.Items.Add(
                                new ComboBoxItem(
                                    reader["id_peminjam"].ToString(),
                                    reader["nama_peminjam"].ToString()
                                )
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data peminjam: " + ex.Message);
            }
        }

        // Menampilkan data alat ke ComboBox
        private void TampilAlat()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = "SELECT id_alat, nama_alat FROM alat";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbAlat.Items.Clear();

                        while (reader.Read())
                        {
                            cmbAlat.Items.Add(
                                new ComboBoxItem(
                                    reader["id_alat"].ToString(),
                                    reader["nama_alat"].ToString()
                                )
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data alat: " + ex.Message);
            }
        }

        // Menampilkan transaksi peminjaman
        private void TampilDataPeminjaman()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            p.id_peminjaman,
                            pm.nama_peminjam,
                            pm.kelas,
                            a.nama_alat,
                            p.jumlah,
                            p.tanggal_pinjam,
                            p.tanggal_kembali,
                            p.status,
                            p.catatan
                        FROM peminjaman p
                        INNER JOIN peminjam pm
                            ON p.id_peminjam = pm.id_peminjam
                        INNER JOIN alat a
                            ON p.id_alat = a.id_alat
                        ORDER BY p.id_peminjaman DESC";

                    using (MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvPeminjaman.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data peminjaman: "
                    + ex.Message);
            }
        }

        // Tombol Simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbPeminjam.SelectedItem == null)
            {
                MessageBox.Show("Pilih peminjam terlebih dahulu!");
                return;
            }

            if (cmbAlat.SelectedItem == null)
            {
                MessageBox.Show("Pilih alat terlebih dahulu!");
                return;
            }

            if (txtJumlah.Text.Trim() == "")
            {
                MessageBox.Show("Jumlah harus diisi!");
                return;
            }

            int jumlah;

            if (!int.TryParse(txtJumlah.Text.Trim(), out jumlah) ||
                jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka lebih dari 0!");
                return;
            }

            try
            {
                ComboBoxItem peminjam =
                    (ComboBoxItem)cmbPeminjam.SelectedItem;

                ComboBoxItem alat =
                    (ComboBoxItem)cmbAlat.SelectedItem;

                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO peminjaman
                        (
                            id_peminjam,
                            id_alat,
                            jumlah,
                            tanggal_pinjam,
                            tanggal_kembali,
                            status,
                            catatan
                        )
                        VALUES
                        (
                            @idpeminjam,
                            @idalat,
                            @jumlah,
                            @tanggalpinjam,
                            @tanggalkembali,
                            @status,
                            @catatan
                        )";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@idpeminjam",
                            peminjam.Value);

                        cmd.Parameters.AddWithValue(
                            "@idalat",
                            alat.Value);

                        cmd.Parameters.AddWithValue(
                            "@jumlah",
                            jumlah);

                        cmd.Parameters.AddWithValue(
                            "@tanggalpinjam",
                            dtpTanggalPinjam.Value);

                        cmd.Parameters.AddWithValue(
                            "@tanggalkembali",
                            dtpTanggalKembali.Value);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            "Pending");

                        cmd.Parameters.AddWithValue(
                            "@catatan",
                            txtCatatan.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data peminjaman berhasil disimpan!");

                cmbPeminjam.SelectedIndex = -1;
                cmbAlat.SelectedIndex = -1;
                txtJumlah.Clear();
                txtCatatan.Clear();

                TampilDataPeminjaman();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan peminjaman: "
                    + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Menyimpan ID database dan nama yang ditampilkan ComboBox
    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}