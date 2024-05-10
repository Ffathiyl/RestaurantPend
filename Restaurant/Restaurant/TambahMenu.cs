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
            /*string connectionString = "integrated security=true;data source=DESKTOP-NJ8K07R\\SQLEXPRESS;initial catalog=P5_072";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertMenu", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("@id_produk", txtIdProd.Text);
            insert.Parameters.AddWithValue("@nama_produk", txtNamaProd.Text);
            insert.Parameters.AddWithValue("@stok", txtJmlStok.Text);
            insert.Parameters.AddWithValue("@id_supplier", cbSupplier.SelectedValue.ToString());

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }*/
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
            txtNama.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
        }
    }
}
