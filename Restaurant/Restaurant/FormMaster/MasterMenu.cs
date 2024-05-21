using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.FormMaster
{
    public partial class MasterMenu : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public MasterMenu()
        {
            InitializeComponent();
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (validasi("Insert"))
            {
                try
                {

                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[sp_inputMsMenu]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mnu_nama", txtnama.Text);
                    cmd.Parameters.AddWithValue("@mnu_deskripsi", txtdeskripsi.Text);
                    string jenis;
                    if (cbjenis.SelectedItem.Equals("Makanan"))
                    {
                        jenis = "1";
                    }
                    else
                    {
                        jenis = "2";
                    }
                    cmd.Parameters.AddWithValue("@mnu_jenis", jenis);
                    cmd.Parameters.AddWithValue("@mnu_harga", txtharga.Text);
                    cmd.Parameters.AddWithValue("@mnu_stok", txtstok.Text);

                    string status;
                    if (cbStatus.SelectedItem.Equals("Aktif"))
                    {
                        status = "1";
                    }
                    else
                    {
                        status = "0";
                    }
                    cmd.Parameters.AddWithValue("@mnu_status", status);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Menu Berhasil Dibuat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clear();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lengkapi Data Terlebih Dahulu ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtid.Enabled = true;
            if (validasi("Update"))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[sp_updateMsMenu]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mnu_id", txtid.Text);
                    cmd.Parameters.AddWithValue("@mnu_nama", txtnama.Text);
                    cmd.Parameters.AddWithValue("@mnu_deskripsi", txtdeskripsi.Text);
                    string jenis;
                    if (cbjenis.SelectedItem.Equals("Makanan"))
                    {
                        jenis = "1";
                    }
                    else
                    {
                        jenis = "2";
                    }
                    cmd.Parameters.AddWithValue("@mnu_jenis", jenis);
                    cmd.Parameters.AddWithValue("@mnu_harga", txtharga.Text);
                    cmd.Parameters.AddWithValue("@mnu_stok", txtstok.Text);

                    string status;
                    if (cbStatus.SelectedItem.Equals("Aktif"))
                    {
                        status = "1";
                    }
                    else
                    {
                        status = "0";
                    }
                    cmd.Parameters.AddWithValue("@mnu_status", status);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Menu Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clear();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Data tidak valid ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("[sp_deleteMsMenu]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mnu_id", txtid.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Menu berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clear();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    //txtUsername.Enabled = false;
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_searchMsMenu]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mnu_nama", txtSearch.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    reader.Close();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgAkun.DataSource = dt;
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Data tidak ditemukan.");
                    dgAkun.DataSource = null; // Menghapus data yang ada sebelumnya
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            autoid();
            clear();
        }

        public void loadData()
        {
            btnTambah.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // TODO: This line of code loads data into the 'dB_RestaurantDataSet1.ms_menu' table. You can move, or remove it, as needed.
            this.ms_menuTableAdapter.Fill(this.dB_RestaurantDataSet1.ms_menu);
            /*try
            {
                clear();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                DataTable dt = new DataTable();
                SqlCommand load = new SqlCommand("SELECT * FROM ms_menu", conn); // Menggunakan view vwStaff sebagai sumber data
                load.CommandType = CommandType.Text; // Perhatikan bahwa command type diubah menjadi Text karena kita menggunakan SQL query langsung
                SqlDataAdapter adapter = new SqlDataAdapter(load);
                adapter.Fill(dt);

                dgAkun.DataSource = dt;
                conn.Close();
                dgAkun.Columns[0].HeaderText = "Id Staff";
                dgAkun.Columns[1].HeaderText = "Nama Staff";
                dgAkun.Columns[2].HeaderText = "Alamat";
                dgAkun.Columns[3].HeaderText = "No Telpon";
                dgAkun.Columns[4].HeaderText = "Username";
                dgAkun.Columns[5].HeaderText = "Jabatan";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        public void clear()
        {
            txtSearch.Clear();
            txtnama.Clear();
            txtharga.Clear();
            txtstok.Clear();
            txtdeskripsi.Clear();
            cbStatus.SelectedIndex = 0;
            cbjenis.SelectedIndex = 0;
        }

        private void MasterMenu_Load(object sender, EventArgs e)
        {
            autoid();
            loadData();
            cbjenis.SelectedItem = "-- Pilih Jenis --";
            cbStatus.SelectedItem = "Aktif";
        }

        private void dgAkun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTambah.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtid.Enabled = false;
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgAkun.Rows[e.RowIndex];
                    txtid.Text = row.Cells[0].Value.ToString();
                    txtnama.Text = row.Cells[1].Value.ToString();
                    txtdeskripsi.Text = row.Cells[2].Value.ToString();
                    //cbjenis.Text = row.Cells[3].Value.ToString();
                    string jenis = row.Cells[3].Value.ToString();
                    if (jenis == "1")
                    {
                        cbjenis.SelectedItem = "Makanan";
                    }
                    else
                    {
                        cbjenis.SelectedItem = "Minuman";
                    }

                    decimal harga = Convert.ToDecimal(row.Cells[4].Value);
                    txtharga.Text = harga.ToString("0.##");
                    txtstok.Text = row.Cells[5].Value.ToString();

                    string sts = row.Cells[6].Value.ToString();
                    if (sts == "1")
                    {
                        cbStatus.SelectedItem = "Aktif";
                    }
                    else
                    {
                        cbStatus.SelectedItem = "Tidak Aktif";
                    }

                }
            }
            catch (Exception ex)
            {
                clear();
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public Boolean validasi(String action)
        {
            Boolean[] check = { false, false, false, false, false, false, false };

            if (!txtid.Text.Equals(""))
            {
                check[0] = true;
            }
            if (!txtnama.Text.Equals(""))
            {
                check[1] = true;
            }
            if (!txtdeskripsi.Text.Equals(""))
            {
                check[2] = true;
            }
            if (!txtharga.Text.Equals(""))
            {
                check[3] = true;
            }
            if (!txtstok.Text.Equals(""))
            {
                check[4] = true;
            }
            
            if (!cbjenis.Text.Equals("-- Pilih Jenis --"))
            {
                check[5] = true;
            }
            if (!cbStatus.Text.Equals(""))
            {
                check[6] = true;
            }


            if (action.Equals("Insert"))
            {
                if (check[0] && check[1] && check[2] && check[3] && check[4] && check[5] && check[6])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (action.Equals("Update"))
            {
                if (check[0] && check[1] && check[2] && check[3] && check[4] && check[5] && check[6])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string autoid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string countQuery = "SELECT COUNT(*) FROM ms_menu";

                SqlCommand countCommand = new SqlCommand(countQuery, conn);

                int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;
                //string newID = "ST" + count.ToString("000");
                txtid.Text = count.ToString();
                return count.ToString();

            }
        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtstok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            string buffer = txtharga.Text.Replace("Rp", "").Replace(",", "").Trim();
            if (decimal.TryParse(buffer, out decimal parsedValue))
            {
                // Format the text as currency
                txtharga.Text = parsedValue.ToString("C", CultureInfo.CurrentCulture);

                // Move the caret to the end of the text
                txtharga.SelectionStart = txtharga.Text.Length;
            }
        }
    }
}
