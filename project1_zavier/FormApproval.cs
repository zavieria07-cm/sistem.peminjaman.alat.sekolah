using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project1_ridho
{
    public partial class FormApproval : Form
    {
        public FormApproval()
        {
            InitializeComponent();

            // Mendaftarkan Event
            this.Load += new EventHandler(FormApproval_Load);
            this.btnACC.Click += new EventHandler(btnACC_Click);
            this.btnTolak.Click += new EventHandler(btnTolak_Click);
        }

        // ==========================================
        // Mengambil data peminjaman yang masih Pending
        // ==========================================
        private void LoadDataPending()
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
                            p.status
                        FROM peminjaman p
                        INNER JOIN peminjam pm
                            ON p.id_peminjam = pm.id_peminjam
                        INNER JOIN alat a
                            ON p.id_alat = a.id_alat
                        WHERE p.status = 'Pending'
                        ORDER BY p.id_peminjaman DESC";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvApproval.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data peminjaman: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FormApproval_Load(object sender, EventArgs e)
        {
            LoadDataPending();
        }

        // ==========================================
        // Memperbarui status peminjaman
        // ==========================================
        private void UpdateStatusPeminjaman(string statusBaru)
        {
            if (dgvApproval.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Silakan pilih peminjaman yang ingin diproses!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Ambil ID Peminjaman
            string idPeminjaman =
                dgvApproval.SelectedRows[0]
                .Cells["id_peminjaman"]
                .Value
                .ToString();

            string catatan = txtCatatan.Text.Trim();

            try
            {
                using (MySqlConnection conn = Koneksi.GetKoneksi())
                {
                    conn.Open();

                    string query = @"
                        UPDATE peminjaman
                        SET status = @status,
                            catatan = @catatan
                        WHERE id_peminjaman = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@status",
                        statusBaru
                    );

                    cmd.Parameters.AddWithValue(
                        "@catatan",
                        catatan
                    );

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idPeminjaman
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Peminjaman berhasil di-" + statusBaru + "!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    txtCatatan.Clear();

                    // Refresh DataGridView
                    LoadDataPending();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memperbarui status peminjaman: "
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // Tombol ACC
        // ==========================================
        private void btnACC_Click(object sender, EventArgs e)
        {
            UpdateStatusPeminjaman("Disetujui");
        }

        // ==========================================
        // Tombol Tolak
        // ==========================================
        private void btnTolak_Click(object sender, EventArgs e)
        {
            UpdateStatusPeminjaman("Ditolak");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}