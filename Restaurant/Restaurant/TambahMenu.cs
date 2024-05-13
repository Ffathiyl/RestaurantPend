using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class TambahMenu : Form
    {
        public TambahMenu()
        {
            InitializeComponent();
        }

        private void TambahMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security=true;data source=DESKTOP-NJ8K07R\\SQLEXPRESS;initial catalog=DB_Restaurant";  //menyambungkan ke database pada sqlserver
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_inputMsMenu", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("@mnu_nama", txtNama.Text);
            insert.Parameters.AddWithValue("@mnu_deskripsi", richTextBoxDeskripsi.Text);
            if (rbMakanan.Checked == true)
            {
                insert.Parameters.AddWithValue("@mnu_jenis", 1);
            }
            else if (rbMinuman.Checked == true)
            {
                insert.Parameters.AddWithValue("@mnu_jenis", 0);
            }
            insert.Parameters.AddWithValue("@mnu_harga", float.Parse(txtHarga.Text));
            insert.Parameters.AddWithValue("@mnu_stok", Int32.Parse(txtStok.Text));
            insert.Parameters.AddWithValue("@mnu_status", 1);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Menu berhasil ditambahkan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan " + ex.Message);
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtNama.Text = "";
            richTextBoxDeskripsi.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
        }
    }
}
