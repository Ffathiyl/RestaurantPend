using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormKasir : Form
    {
        private Form currchildform;
        public FormKasir(string[] data)
        {
            InitializeComponent();

            lblNama.Text = data[0];
            lblJabatan.Text = data[1];
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "LogOut!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new LoginForm().Show();
                //kill this
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void openChildForm(Form childForm)
        {
            if (currchildform != null)
            {
                currchildform.Close();
            }
            currchildform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            guna2Panel2.Controls.Add(childForm);
            guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTrsMakanan_Click(object sender, EventArgs e)
        {

        }
    }
}
