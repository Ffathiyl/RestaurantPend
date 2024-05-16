using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class LoginForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set fokus pertama pada txtUsername
            this.ActiveControl = txtUsername;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                //login form
                //cek username dan password
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Username atau password tidak boleh kosong");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("[sp_Login]", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //string result = reader["result"].ToString();
                            //if (result == "Success")
                            //{
                                int jabatan = Convert.ToInt32(reader["usr_role"].ToString());
                                string nama = reader["usr_nama"].ToString();
                                
                                if (jabatan == 2)
                                {
                                    string[] data = { nama, "Manager" };
                                    // lakukan tindakan setelah login berhasil
                                    MessageBox.Show("Login berhasil! Jabatan: " + "Manager");
                                    new FormManager(data).Show();
                                    this.Hide();
                                }
                                else
                                {
                                    string[] data = { nama, "Kasir" };
                                    // lakukan tindakan setelah login berhasil
                                    MessageBox.Show("Login berhasil! Jabatan: " + "kasir");
                                    new FormKasir(data).Show();
                                    this.Hide();
                                }
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Login gagal. Silakan coba lagi.");
                            //}
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login gagal. Silakan coba lagi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
