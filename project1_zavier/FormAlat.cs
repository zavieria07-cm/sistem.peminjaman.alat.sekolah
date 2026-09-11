using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormPenduduk : Form
    {
        public FormPenduduk()
        {
            InitializeComponent();

            // ==========================================
            // ISI COMBOBOX JUMLAH
            // ==========================================

            cmbJumlah.Items.Add("1");
            cmbJumlah.Items.Add("2");
            cmbJumlah.Items.Add("3");
            cmbJumlah.Items.Add("4");
            cmbJumlah.Items.Add("5");
            cmbJumlah.Items.Add("6");
            cmbJumlah.Items.Add("7");
            cmbJumlah.Items.Add("8");
            cmbJumlah.Items.Add("9");
            cmbJumlah.Items.Add("10");

            // ==========================================
            // ISI COMBOBOX KONDISI
            // ==========================================

            cmbKondisi.Items.Add("Baik");
            cmbKondisi.Items.Add("Rusak Ringan");
            cmbKondisi.Items.Add("Rusak Berat");

            // ==========================================
            // TAMPILKAN DATA SAAT FORM DIBUKA
            // ==========================================

            LoadDataAlat();
        }

        // ==========================================
        // FUNGSI MENAMPILKAN DATA ALAT
        // ==========================================

        private void LoadDataAlat()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            id_alat,
                            kode_alat,
                            nama_alat,
                            jumlah,
                            kondisi,
                            lokasi
                        FROM alat
                        ORDER BY id_alat DESC";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    System.Data.DataTable dt =
                        new System.Data.DataTable();

                    da.Fill(dt);

                    dgvAlat.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data alat: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // TOMBOL SIMPAN
        // ==========================================

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // ==========================================
            // 1. VALIDASI INPUT
            // ==========================================

            if (string.IsNullOrWhiteSpace(txtKodeAlat.Text) ||
                string.IsNullOrWhiteSpace(txtNamaAlat.Text))
            {
                MessageBox.Show(
                    "Kode alat dan nama alat wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbJumlah.SelectedItem == null)
            {
                MessageBox.Show(
                    "Silakan pilih jumlah alat!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbKondisi.SelectedItem == null)
            {
                MessageBox.Show(
                    "Silakan pilih kondisi alat!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtLokasi.Text))
            {
                MessageBox.Show(
                    "Lokasi alat wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // ==========================================
                // 2. BUKA KONEKSI DATABASE
                // ==========================================

                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    // ==========================================
                    // 3. QUERY SIMPAN DATA ALAT
                    // ==========================================

                    string query = @"
                        INSERT INTO alat
                        (kode_alat, nama_alat, jumlah, kondisi, lokasi)
                        VALUES
                        (@kode_alat, @nama_alat, @jumlah, @kondisi, @lokasi)";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@kode_alat",
                            txtKodeAlat.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@nama_alat",
                            txtNamaAlat.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@jumlah",
                            Convert.ToInt32(
                                cmbJumlah.SelectedItem.ToString()
                            )
                        );

                        cmd.Parameters.AddWithValue(
                            "@kondisi",
                            cmbKondisi.SelectedItem.ToString()
                        );

                        cmd.Parameters.AddWithValue(
                            "@lokasi",
                            txtLokasi.Text.Trim()
                        );

                        // ==========================================
                        // 4. EKSEKUSI QUERY
                        // ==========================================

                        cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            "Data alat berhasil disimpan!",
                            "Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // ==========================================
                        // 5. REFRESH DATAGRIDVIEW
                        // ==========================================

                        LoadDataAlat();

                        // ==========================================
                        // 6. RESET INPUT
                        // ==========================================

                        txtKodeAlat.Clear();
                        txtNamaAlat.Clear();

                        cmbJumlah.SelectedIndex = -1;
                        cmbKondisi.SelectedIndex = -1;

                        txtLokasi.Clear();

                        txtKodeAlat.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data alat: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // EVENT LAMA DARI FORM TEMAN
        // ==========================================

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}