using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class TransaksiMenu : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        string[] temp;

        public TransaksiMenu()
        {
            InitializeComponent();
        }

        private void cmbnamasnack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbnamasnack.SelectedIndex != -1)
            {
                string id = cmbnamasnack.SelectedValue.ToString(); // Mengambil nilai id yang dipilih dari ComboBox
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    string query = "SELECT mnu_nama, mnu_stok, mnu_harga FROM ms_menu WHERE mnu_id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int stock = reader.GetInt32(reader.GetOrdinal("mnu_stok"));
                        txtstock.Text = stock.ToString();
                        decimal harga = reader.GetDecimal(reader.GetOrdinal("mnu_harga"));
                        txtjual.Text = harga.ToString("#,0");
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Terjadi error saat load data " + ex.Message);
                }
            }
            else
            {
                txtstock.Text = "";
                txtjual.Text = "";
                tmptgl.MinDate = DateTime.Now;
            }
        }

        private void btnTPesan_Click(object sender, EventArgs e)
        {
            if (txtbayar.Text != null)
            {
                string staff = "kasir";
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("TrsPesanMenu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@trs_createby", staff);
                    cmd.Parameters.AddWithValue("@trs_pelanggan", txtPelanggan.Text);

                    decimal totalHarga;
                    if (decimal.TryParse(txtTotal.Text, out totalHarga))
                    {
                        cmd.Parameters.AddWithValue("@trs_total", totalHarga);
                    }
                    else
                    {
                        // Nilai tidak valid, berikan nilai default atau tangani kesalahan sesuai kebutuhan
                        cmd.Parameters.AddWithValue("@trs_total", DBNull.Value);
                    }

                    DateTime tanggal;
                    if (DateTime.TryParse(tmptgl.Text, out tanggal))
                    {
                        cmd.Parameters.AddWithValue("@trs_tanggal", tanggal);
                    }
                    else
                    {
                        // Nilai tidak valid, berikan nilai default atau tangani kesalahan sesuai kebutuhan
                        cmd.Parameters.AddWithValue("@trs_tanggal", DBNull.Value);
                    }

                    
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < dgtransaksi.Rows.Count; i++)
                    {
                        string snackID = dgtransaksi.Rows[i].Cells["id_snack"].Value.ToString();
                        int jumlah;

                        if (int.TryParse(dgtransaksi.Rows[i].Cells["banyak_snack"].Value.ToString(), out jumlah))
                        {
                            SqlCommand command = new SqlCommand("DetailTrsMenu", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@trs_id", txtID.Text);
                            command.Parameters.AddWithValue("@mnu_id", snackID);
                            command.Parameters.AddWithValue("@jumlah", jumlah);

                            command.ExecuteNonQuery();

                            // Kurangi stok snack
                            string updateStockQuery = "UPDATE ms_menu SET mnu_stok = mnu_stok - @jumlah WHERE mnu_id = @mnu_id";
                            SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, conn);
                            updateStockCommand.Parameters.AddWithValue("@jumlah", jumlah);
                            updateStockCommand.Parameters.AddWithValue("@mnu_id", snackID);
                            updateStockCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            // Nilai tidak valid, berikan nilai default atau tangani kesalahan sesuai kebutuhan
                        }
                    }

                    MessageBox.Show("Insert Transaksi Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                btnbatal_Click(sender, new EventArgs());
            }
            else
            {
                MessageBox.Show("Harap melakukan Pembayaran", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            clearpick();
            autoid();

            txtkembalian.Text = "";
            txtTotal.Text = "";
            txtbayar.Text = "";

            for (int i = dgtransaksi.Rows.Count - 1; i >= 0; i--)
            {
                dgtransaksi.Rows.RemoveAt(i);
            }

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if (cmbnamasnack.Text != "")
            {
                bool found = false;
                if (dgtransaksi.Rows.Count > 0)
                {
                    for (int i = 0; i < dgtransaksi.Rows.Count; i++)
                    {
                        if (dgtransaksi.Rows[i].Cells[0].Value != null && dgtransaksi.Rows[i].Cells[1].Value.ToString() == cmbnamasnack.Text)
                        {
                            int quantity = Convert.ToInt32(dgtransaksi.Rows[i].Cells[4].Value);
                            int quantity2 = Convert.ToInt32(txtjmlh.Text);
                            int total = quantity2 + quantity;
                            decimal totalharga = Convert.ToDecimal(txtjual.Text) * total;

                            
                            dgtransaksi.Rows[i].Cells[4].Value = total.ToString();

                            dgtransaksi.Rows[i].Cells[5].Value = totalharga.ToString();
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    int quantity = Convert.ToInt32(txtjmlh.Text);
                    decimal total = Convert.ToDecimal(txtjual.Text) * quantity;

                    // Mengambil ID Snack dari Value Member ComboBox
                    string idSnack = Convert.ToString(cmbnamasnack.SelectedValue);

                    dgtransaksi.Rows.Add(idSnack, cmbnamasnack.Text, txtstock.Text, txtjual.Text, quantity, total);
                }
            }
            else
            {
                MessageBox.Show("Pilih Menu!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clearpick();
        }

        private void clearpick()
        {
            txtjual.Text = "";
            cmbnamasnack.SelectedIndex = -1;
            txtjmlh.Text = "";
            txtTotal.Text = "";
        }

        private void TransaksiMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RestaurantDataSet1.ms_menu' table. You can move, or remove it, as needed.
            this.ms_menuTableAdapter.Fill(this.dB_RestaurantDataSet1.ms_menu);

            tmptgl.MinDate = DateTime.Now;
            autoid();
        }

        public string autoid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string countQuery = "SELECT COUNT(*) FROM tr_pesanan";

                using (SqlCommand countCommand = new SqlCommand(countQuery, conn))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = count.ToString();

                    txtID.Text = newID;
                    return newID;
                }
            }
        }

        private void txtbayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double totalHarga = 0;
                double totalBayar = 0;

                if (double.TryParse(txtTotal.Text, out totalHarga) && double.TryParse(txtbayar.Text, out totalBayar))
                {
                    txtbayar.Text = totalBayar.ToString("#,0");
                    if (totalBayar < totalHarga)
                    {
                        MessageBox.Show("Jumlah uang yang dibayarkan harus sama atau lebih dari total harga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbayar.Text = "";
                    }
                    else
                    {
                        double kembalian = totalBayar - totalHarga;
                        txtkembalian.Text = kembalian.ToString("#,0");
                    }
                }
                else
                {
                    MessageBox.Show("Input tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbayar.Text = "";
                }
            }
        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            string input = txtbayar.Text;
            string cleaninput = Regex.Replace(input, "[^0-9]", "");

            if (!string.IsNullOrEmpty(cleaninput))
            {
                double pembayaran = double.Parse(cleaninput);
                txtbayar.Text = pembayaran.ToString("#,0");
                txtbayar.SelectionStart = txtbayar.Text.Length;
            }
        }

        private void txtTotal_MouseClick(object sender, MouseEventArgs e)
        {
            double temp, total = 0.0;
            foreach (DataGridViewRow row in dgtransaksi.Rows)
            {
                if (!row.IsNewRow)
                {
                    
                    double price = Convert.ToDouble(row.Cells[5].Value);
                    
                    total += price;
                }
            }
            txtTotal.Text = total.ToString("#,0");
        }
    }
}
