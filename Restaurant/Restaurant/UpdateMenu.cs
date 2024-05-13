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
    public partial class UpdateMenu : Form
    {
        public UpdateMenu()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string jenis;
            string connectionString = "integrated security=true;data source=DESKTOP-NJ8K07R\\SQLEXPRESS;initial catalog=DB_Restaurant";  //menyambungkan ke database pada sqlserver
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                DataTable DT = new DataTable();
                SqlCommand command = new SqlCommand("sp_SearchMenu", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mnu_id", Int32.Parse(txtId.Text));
                SqlDataAdapter DA = new SqlDataAdapter(command);
                DA.Fill(DT);
                if (DT.Rows.Count > 0)
                {
                    txtNama.Text = DT.Rows[0]["mnu_nama"].ToString();
                    richTextBoxDeskripsi.Text = DT.Rows[0]["mnu_deskripsi"].ToString();
                    if (Int32.Parse(DT.Rows[0]["mnu_jenis"].ToString()) == 1)
                    {
                        rbMakanan.Checked = true;
                    }
                    else
                    {
                        rbMinuman.Checked = true;
                    }
                    txtHarga.Text = DT.Rows[0]["mnu_harga"].ToString();
                    txtStok.Text = DT.Rows[0]["mnu_stok"].ToString();
                    if (Int32.Parse(DT.Rows[0]["mnu_jenis"].ToString()) == 1)
                    {
                        rbAktif.Checked = true;
                    }
                    else
                    {
                        rbNonAktif.Checked = true;
                    }
                    txtId.Enabled = false;
                    txtNama.Enabled = true;
                    richTextBoxDeskripsi.Enabled = true;
                    txtHarga.Enabled = true;
                    txtStok.Enabled = true;
                    rbMakanan.Enabled = true;
                    rbMinuman.Enabled = true;
                    rbAktif.Enabled = true;
                    rbNonAktif.Enabled = true;
                    btnUpdate.Enabled = true;

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Menu tidak ditemukan!", "Error", MessageBoxButtons.OK);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK);
                connection.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security=true;data source=DESKTOP-NJ8K07R\\SQLEXPRESS;initial catalog=DB_Restaurant";  //menyambungkan ke database pada sqlserver
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand update = new SqlCommand("sp_updateMsMenu", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("@mnu_id", Int32.Parse(txtId.Text));
            update.Parameters.AddWithValue("@mnu_nama", txtNama.Text);
            update.Parameters.AddWithValue("@mnu_deskripsi", richTextBoxDeskripsi.Text);
            if (rbMakanan.Checked == true)
            {
                update.Parameters.AddWithValue("@mnu_jenis", 1);
            } else if (rbMinuman.Checked == true)
            {
                update.Parameters.AddWithValue("@mnu_jenis", 0);
            }
            update.Parameters.AddWithValue("@mnu_harga", float.Parse(txtHarga.Text));
            update.Parameters.AddWithValue("@mnu_stok", Int32.Parse(txtStok.Text));
            if (rbAktif.Checked == true)
            {
                update.Parameters.AddWithValue("@mnu_status", 1);
            }
            else if (rbNonAktif.Checked == true)
            {
                update.Parameters.AddWithValue("@mnu_status", 0);
            }

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Menu berhasil di update", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal melakukan update " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtId.Text = "";
            txtNama.Text = "";
            richTextBoxDeskripsi.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
            txtId.Enabled = true;
            txtNama.Enabled = false;
            richTextBoxDeskripsi.Enabled = false;
            txtHarga.Enabled = false;
            txtStok.Enabled = false;
            rbMakanan.Enabled = false;
            rbMinuman.Enabled = false;
            rbAktif.Enabled = false;
            rbNonAktif.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void UpdateMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
