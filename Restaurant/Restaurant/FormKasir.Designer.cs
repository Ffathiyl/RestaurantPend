namespace Restaurant
{
    partial class FormKasir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrsMakanan = new Guna.UI2.WinForms.Guna2Button();
            this.lblNama = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblJabatan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ButtonMenu);
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.btnTrsMakanan);
            this.guna2Panel1.Controls.Add(this.lblNama);
            this.guna2Panel1.Controls.Add(this.lblJabatan);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 11);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(267, 1066);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(3, 413);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(263, 55);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTrsMakanan
            // 
            this.btnTrsMakanan.CheckedState.Parent = this.btnTrsMakanan;
            this.btnTrsMakanan.CustomImages.Parent = this.btnTrsMakanan;
            this.btnTrsMakanan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnTrsMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrsMakanan.ForeColor = System.Drawing.Color.Black;
            this.btnTrsMakanan.HoverState.Parent = this.btnTrsMakanan;
            this.btnTrsMakanan.Location = new System.Drawing.Point(3, 350);
            this.btnTrsMakanan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrsMakanan.Name = "btnTrsMakanan";
            this.btnTrsMakanan.ShadowDecoration.Parent = this.btnTrsMakanan;
            this.btnTrsMakanan.Size = new System.Drawing.Size(263, 55);
            this.btnTrsMakanan.TabIndex = 18;
            this.btnTrsMakanan.Text = "Transaksi Pembelian";
            this.btnTrsMakanan.Click += new System.EventHandler(this.btnTrsMakanan_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = false;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.Black;
            this.lblNama.Location = new System.Drawing.Point(132, 85);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(120, 24);
            this.lblNama.TabIndex = 17;
            this.lblNama.Text = "Nama";
            this.lblNama.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJabatan
            // 
            this.lblJabatan.BackColor = System.Drawing.Color.Transparent;
            this.lblJabatan.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJabatan.ForeColor = System.Drawing.Color.Black;
            this.lblJabatan.Location = new System.Drawing.Point(132, 49);
            this.lblJabatan.Margin = new System.Windows.Forms.Padding(4);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(76, 28);
            this.lblJabatan.TabIndex = 16;
            this.lblJabatan.Text = "Jabatan";
            this.lblJabatan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(279, 11);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1651, 1066);
            this.guna2Panel2.TabIndex = 1;
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.CheckedState.Parent = this.ButtonMenu;
            this.ButtonMenu.CustomImages.Parent = this.ButtonMenu;
            this.ButtonMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.ButtonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenu.ForeColor = System.Drawing.Color.Black;
            this.ButtonMenu.HoverState.Parent = this.ButtonMenu;
            this.ButtonMenu.Location = new System.Drawing.Point(3, 287);
            this.ButtonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.ShadowDecoration.Parent = this.ButtonMenu;
            this.ButtonMenu.Size = new System.Drawing.Size(263, 55);
            this.ButtonMenu.TabIndex = 20;
            this.ButtonMenu.Text = "Menu";
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // FormKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1088);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKasir";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormKasir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNama;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblJabatan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnTrsMakanan;
        private Guna.UI2.WinForms.Guna2Button ButtonMenu;
    }
}