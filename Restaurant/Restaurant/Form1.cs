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
    public partial class Form1 : Form
    {
        private string Stringconnection = "integrated security=true;server=DESKTOP-NM792QH;database=DB_Restaurant";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btn_Login_Click(object sender, EventArgs e) {
            if(txt_Username.Text == ""|| txt_Password.Text == "") {
                MessageBox.Show("Masukan Username dan Password", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                using (SqlConnection connection = new SqlConnection(Stringconnection)) {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_Login", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("username", txt_Username.Text);
                    cmd.Parameters.AddWithValue("password", txt_Password.Text);
                    try {
                        string buffer = Convert.ToString(cmd.ExecuteScalar());
                        if(String.IsNullOrEmpty(buffer)) {
                            MessageBox.Show("Username atau Password salah");
                        } else {
                            if(buffer == "1") {
                                // code
                            }else if(buffer == "0") {
                                // code
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
