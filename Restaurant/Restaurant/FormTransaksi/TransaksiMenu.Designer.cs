namespace Restaurant
{
    partial class TransaksiMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.snackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPelanggan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtjmlh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmptgl = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btntambah = new Guna.UI2.WinForms.Guna2Button();
            this.txtjual = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstock = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbnamasnack = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTPesan = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbayar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnbatal = new Guna.UI2.WinForms.Guna2Button();
            this.txtkembalian = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgtransaksi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_snack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snack_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snack_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snack_hargajual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyak_snack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkasir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dB_RestaurantDataSet1 = new Restaurant.DB_RestaurantDataSet1();
            this.msmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ms_menuTableAdapter = new Restaurant.DB_RestaurantDataSet1TableAdapters.ms_menuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.snackBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(568, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(404, 36);
            this.label13.TabIndex = 83;
            this.label13.Text = "TRANSAKSI PENJUALAN MENU";
            // 
            // snackBindingSource
            // 
            this.snackBindingSource.DataMember = "snack";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txtkasir);
            this.guna2Panel1.Controls.Add(this.txtPelanggan);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Controls.Add(this.txtjmlh);
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.tmptgl);
            this.guna2Panel1.Controls.Add(this.btntambah);
            this.guna2Panel1.Controls.Add(this.txtjual);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.txtID);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtstock);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.cmbnamasnack);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(80, 160);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1388, 283);
            this.guna2Panel1.TabIndex = 73;
            // 
            // txtPelanggan
            // 
            this.txtPelanggan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPelanggan.DefaultText = "";
            this.txtPelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPelanggan.DisabledState.Parent = this.txtPelanggan;
            this.txtPelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPelanggan.FocusedState.Parent = this.txtPelanggan;
            this.txtPelanggan.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelanggan.ForeColor = System.Drawing.Color.Black;
            this.txtPelanggan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPelanggan.HoverState.Parent = this.txtPelanggan;
            this.txtPelanggan.Location = new System.Drawing.Point(1072, 100);
            this.txtPelanggan.Margin = new System.Windows.Forms.Padding(4);
            this.txtPelanggan.Name = "txtPelanggan";
            this.txtPelanggan.PasswordChar = '\0';
            this.txtPelanggan.PlaceholderText = "";
            this.txtPelanggan.SelectedText = "";
            this.txtPelanggan.ShadowDecoration.Parent = this.txtPelanggan;
            this.txtPelanggan.Size = new System.Drawing.Size(267, 32);
            this.txtPelanggan.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(797, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 24);
            this.label12.TabIndex = 57;
            this.label12.Text = "Pelanggan";
            // 
            // txtjmlh
            // 
            this.txtjmlh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtjmlh.DefaultText = "";
            this.txtjmlh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtjmlh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtjmlh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjmlh.DisabledState.Parent = this.txtjmlh;
            this.txtjmlh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjmlh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjmlh.FocusedState.Parent = this.txtjmlh;
            this.txtjmlh.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjmlh.ForeColor = System.Drawing.Color.Black;
            this.txtjmlh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjmlh.HoverState.Parent = this.txtjmlh;
            this.txtjmlh.Location = new System.Drawing.Point(238, 231);
            this.txtjmlh.Margin = new System.Windows.Forms.Padding(4);
            this.txtjmlh.Name = "txtjmlh";
            this.txtjmlh.PasswordChar = '\0';
            this.txtjmlh.PlaceholderText = "";
            this.txtjmlh.SelectedText = "";
            this.txtjmlh.ShadowDecoration.Parent = this.txtjmlh;
            this.txtjmlh.Size = new System.Drawing.Size(267, 32);
            this.txtjmlh.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 54;
            // 
            // tmptgl
            // 
            this.tmptgl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tmptgl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tmptgl.CheckedState.Parent = this.tmptgl;
            this.tmptgl.FillColor = System.Drawing.Color.White;
            this.tmptgl.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmptgl.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tmptgl.HoverState.Parent = this.tmptgl;
            this.tmptgl.Location = new System.Drawing.Point(1072, 163);
            this.tmptgl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tmptgl.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tmptgl.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tmptgl.Name = "tmptgl";
            this.tmptgl.ShadowDecoration.Parent = this.tmptgl;
            this.tmptgl.Size = new System.Drawing.Size(264, 29);
            this.tmptgl.TabIndex = 53;
            this.tmptgl.Value = new System.DateTime(2023, 7, 10, 15, 16, 37, 382);
            // 
            // btntambah
            // 
            this.btntambah.CheckedState.Parent = this.btntambah;
            this.btntambah.CustomImages.Parent = this.btntambah;
            this.btntambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btntambah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btntambah.ForeColor = System.Drawing.Color.Black;
            this.btntambah.HoverState.Parent = this.btntambah;
            this.btntambah.Location = new System.Drawing.Point(592, 217);
            this.btntambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntambah.Name = "btntambah";
            this.btntambah.ShadowDecoration.Parent = this.btntambah;
            this.btntambah.Size = new System.Drawing.Size(160, 41);
            this.btntambah.TabIndex = 52;
            this.btntambah.Text = "Tambah Item";
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // txtjual
            // 
            this.txtjual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtjual.DefaultText = "";
            this.txtjual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtjual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtjual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjual.DisabledState.Parent = this.txtjual;
            this.txtjual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjual.FocusedState.Parent = this.txtjual;
            this.txtjual.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjual.ForeColor = System.Drawing.Color.Black;
            this.txtjual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjual.HoverState.Parent = this.txtjual;
            this.txtjual.Location = new System.Drawing.Point(238, 167);
            this.txtjual.Margin = new System.Windows.Forms.Padding(4);
            this.txtjual.Name = "txtjual";
            this.txtjual.PasswordChar = '\0';
            this.txtjual.PlaceholderText = "";
            this.txtjual.ReadOnly = true;
            this.txtjual.SelectedText = "";
            this.txtjual.ShadowDecoration.Parent = this.txtjual;
            this.txtjual.Size = new System.Drawing.Size(267, 32);
            this.txtjual.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Harga Jual";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(1072, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(267, 32);
            this.txtID.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID Transaksi";
            // 
            // txtstock
            // 
            this.txtstock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstock.DefaultText = "";
            this.txtstock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.DisabledState.Parent = this.txtstock;
            this.txtstock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.FocusedState.Parent = this.txtstock;
            this.txtstock.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.ForeColor = System.Drawing.Color.Black;
            this.txtstock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstock.HoverState.Parent = this.txtstock;
            this.txtstock.Location = new System.Drawing.Point(238, 102);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.PasswordChar = '\0';
            this.txtstock.PlaceholderText = "";
            this.txtstock.ReadOnly = true;
            this.txtstock.SelectedText = "";
            this.txtstock.ShadowDecoration.Parent = this.txtstock;
            this.txtstock.Size = new System.Drawing.Size(267, 32);
            this.txtstock.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(797, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tanggal Penjualan";
            // 
            // cmbnamasnack
            // 
            this.cmbnamasnack.BackColor = System.Drawing.Color.Transparent;
            this.cmbnamasnack.DataSource = this.msmenuBindingSource;
            this.cmbnamasnack.DisplayMember = "mnu_nama";
            this.cmbnamasnack.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbnamasnack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnamasnack.FocusedColor = System.Drawing.Color.Empty;
            this.cmbnamasnack.FocusedState.Parent = this.cmbnamasnack;
            this.cmbnamasnack.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnamasnack.ForeColor = System.Drawing.Color.Black;
            this.cmbnamasnack.FormattingEnabled = true;
            this.cmbnamasnack.HoverState.Parent = this.cmbnamasnack;
            this.cmbnamasnack.ItemHeight = 30;
            this.cmbnamasnack.ItemsAppearance.Parent = this.cmbnamasnack;
            this.cmbnamasnack.Location = new System.Drawing.Point(238, 39);
            this.cmbnamasnack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbnamasnack.Name = "cmbnamasnack";
            this.cmbnamasnack.ShadowDecoration.Parent = this.cmbnamasnack;
            this.cmbnamasnack.Size = new System.Drawing.Size(264, 36);
            this.cmbnamasnack.TabIndex = 0;
            this.cmbnamasnack.ValueMember = "mnu_id";
            this.cmbnamasnack.SelectedIndexChanged += new System.EventHandler(this.cmbnamasnack_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Stock\r\n";
            // 
            // btnTPesan
            // 
            this.btnTPesan.CheckedState.Parent = this.btnTPesan;
            this.btnTPesan.CustomImages.Parent = this.btnTPesan;
            this.btnTPesan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnTPesan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTPesan.ForeColor = System.Drawing.Color.Black;
            this.btnTPesan.HoverState.Parent = this.btnTPesan;
            this.btnTPesan.Location = new System.Drawing.Point(368, 868);
            this.btnTPesan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTPesan.Name = "btnTPesan";
            this.btnTPesan.ShadowDecoration.Parent = this.btnTPesan;
            this.btnTPesan.Size = new System.Drawing.Size(230, 57);
            this.btnTPesan.TabIndex = 75;
            this.btnTPesan.Text = "Tambah Pesanan";
            this.btnTPesan.Click += new System.EventHandler(this.btnTPesan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(891, 724);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "Kembalian";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 787);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 78;
            this.label9.Text = "Bayar";
            // 
            // txtbayar
            // 
            this.txtbayar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbayar.DefaultText = "";
            this.txtbayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbayar.DisabledState.Parent = this.txtbayar;
            this.txtbayar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbayar.FocusedState.Parent = this.txtbayar;
            this.txtbayar.ForeColor = System.Drawing.Color.Black;
            this.txtbayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbayar.HoverState.Parent = this.txtbayar;
            this.txtbayar.Location = new System.Drawing.Point(390, 780);
            this.txtbayar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.PasswordChar = '\0';
            this.txtbayar.PlaceholderText = "";
            this.txtbayar.SelectedText = "";
            this.txtbayar.ShadowDecoration.Parent = this.txtbayar;
            this.txtbayar.Size = new System.Drawing.Size(267, 32);
            this.txtbayar.TabIndex = 79;
            this.txtbayar.TextChanged += new System.EventHandler(this.txtbayar_TextChanged);
            this.txtbayar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbayar_KeyDown);
            // 
            // btnbatal
            // 
            this.btnbatal.CheckedState.Parent = this.btnbatal;
            this.btnbatal.CustomImages.Parent = this.btnbatal;
            this.btnbatal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnbatal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnbatal.ForeColor = System.Drawing.Color.Black;
            this.btnbatal.HoverState.Parent = this.btnbatal;
            this.btnbatal.Location = new System.Drawing.Point(1018, 868);
            this.btnbatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.ShadowDecoration.Parent = this.btnbatal;
            this.btnbatal.Size = new System.Drawing.Size(230, 57);
            this.btnbatal.TabIndex = 82;
            this.btnbatal.Text = "Batal Pesanan";
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // txtkembalian
            // 
            this.txtkembalian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkembalian.DefaultText = "";
            this.txtkembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtkembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtkembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkembalian.DisabledState.Parent = this.txtkembalian;
            this.txtkembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtkembalian.FocusedState.Parent = this.txtkembalian;
            this.txtkembalian.ForeColor = System.Drawing.Color.Black;
            this.txtkembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtkembalian.HoverState.Parent = this.txtkembalian;
            this.txtkembalian.Location = new System.Drawing.Point(1018, 717);
            this.txtkembalian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtkembalian.Name = "txtkembalian";
            this.txtkembalian.PasswordChar = '\0';
            this.txtkembalian.PlaceholderText = "";
            this.txtkembalian.ReadOnly = true;
            this.txtkembalian.SelectedText = "";
            this.txtkembalian.ShadowDecoration.Parent = this.txtkembalian;
            this.txtkembalian.Size = new System.Drawing.Size(267, 32);
            this.txtkembalian.TabIndex = 81;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgtransaksi);
            this.guna2Panel2.Location = new System.Drawing.Point(80, 440);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1388, 244);
            this.guna2Panel2.TabIndex = 74;
            // 
            // dgtransaksi
            // 
            this.dgtransaksi.AllowUserToAddRows = false;
            this.dgtransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgtransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgtransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgtransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgtransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgtransaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgtransaksi.ColumnHeadersHeight = 30;
            this.dgtransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_snack,
            this.snack_nama,
            this.snack_stock,
            this.snack_hargajual,
            this.banyak_snack,
            this.total_harga});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtransaksi.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgtransaksi.EnableHeadersVisualStyles = false;
            this.dgtransaksi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtransaksi.Location = new System.Drawing.Point(36, 25);
            this.dgtransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgtransaksi.Name = "dgtransaksi";
            this.dgtransaksi.ReadOnly = true;
            this.dgtransaksi.RowHeadersVisible = false;
            this.dgtransaksi.RowHeadersWidth = 62;
            this.dgtransaksi.RowTemplate.Height = 28;
            this.dgtransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtransaksi.Size = new System.Drawing.Size(1316, 190);
            this.dgtransaksi.TabIndex = 0;
            this.dgtransaksi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgtransaksi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtransaksi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgtransaksi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgtransaksi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgtransaksi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgtransaksi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgtransaksi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtransaksi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgtransaksi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtransaksi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgtransaksi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgtransaksi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgtransaksi.ThemeStyle.HeaderStyle.Height = 30;
            this.dgtransaksi.ThemeStyle.ReadOnly = true;
            this.dgtransaksi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgtransaksi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgtransaksi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgtransaksi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgtransaksi.ThemeStyle.RowsStyle.Height = 28;
            this.dgtransaksi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgtransaksi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id_snack
            // 
            this.id_snack.HeaderText = "Id Snack";
            this.id_snack.MinimumWidth = 8;
            this.id_snack.Name = "id_snack";
            this.id_snack.ReadOnly = true;
            // 
            // snack_nama
            // 
            this.snack_nama.HeaderText = "Nama";
            this.snack_nama.MinimumWidth = 8;
            this.snack_nama.Name = "snack_nama";
            this.snack_nama.ReadOnly = true;
            // 
            // snack_stock
            // 
            this.snack_stock.HeaderText = "Stock";
            this.snack_stock.MinimumWidth = 8;
            this.snack_stock.Name = "snack_stock";
            this.snack_stock.ReadOnly = true;
            // 
            // snack_hargajual
            // 
            this.snack_hargajual.HeaderText = "Harga";
            this.snack_hargajual.MinimumWidth = 8;
            this.snack_hargajual.Name = "snack_hargajual";
            this.snack_hargajual.ReadOnly = true;
            // 
            // banyak_snack
            // 
            this.banyak_snack.HeaderText = "Banyak Snack";
            this.banyak_snack.MinimumWidth = 8;
            this.banyak_snack.Name = "banyak_snack";
            this.banyak_snack.ReadOnly = true;
            // 
            // total_harga
            // 
            this.total_harga.HeaderText = "Total Harga";
            this.total_harga.MinimumWidth = 8;
            this.total_harga.Name = "total_harga";
            this.total_harga.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(390, 710);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(267, 32);
            this.txtTotal.TabIndex = 77;
            this.txtTotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTotal_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 717);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Total";
            // 
            // txtkasir
            // 
            this.txtkasir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkasir.DefaultText = "";
            this.txtkasir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtkasir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtkasir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkasir.DisabledState.Parent = this.txtkasir;
            this.txtkasir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkasir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtkasir.FocusedState.Parent = this.txtkasir;
            this.txtkasir.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkasir.ForeColor = System.Drawing.Color.Black;
            this.txtkasir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtkasir.HoverState.Parent = this.txtkasir;
            this.txtkasir.Location = new System.Drawing.Point(1072, 226);
            this.txtkasir.Margin = new System.Windows.Forms.Padding(4);
            this.txtkasir.Name = "txtkasir";
            this.txtkasir.PasswordChar = '\0';
            this.txtkasir.PlaceholderText = "";
            this.txtkasir.SelectedText = "";
            this.txtkasir.ShadowDecoration.Parent = this.txtkasir;
            this.txtkasir.Size = new System.Drawing.Size(267, 32);
            this.txtkasir.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Kasir";
            // 
            // dB_RestaurantDataSet1
            // 
            this.dB_RestaurantDataSet1.DataSetName = "DB_RestaurantDataSet1";
            this.dB_RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // msmenuBindingSource
            // 
            this.msmenuBindingSource.DataMember = "ms_menu";
            this.msmenuBindingSource.DataSource = this.dB_RestaurantDataSet1;
            // 
            // ms_menuTableAdapter
            // 
            this.ms_menuTableAdapter.ClearBeforeFill = true;
            // 
            // TransaksiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 970);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnTPesan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.txtkembalian);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransaksiMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransaksiMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransaksiMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snackBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource snackBindingSource;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPelanggan;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtjmlh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker tmptgl;
        private Guna.UI2.WinForms.Guna2Button btntambah;
        private Guna.UI2.WinForms.Guna2TextBox txtjual;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtstock;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbnamasnack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnTPesan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtbayar;
        private Guna.UI2.WinForms.Guna2Button btnbatal;
        private Guna.UI2.WinForms.Guna2TextBox txtkembalian;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgtransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_snack;
        private System.Windows.Forms.DataGridViewTextBoxColumn snack_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn snack_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn snack_hargajual;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyak_snack;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_harga;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtkasir;
        private DB_RestaurantDataSet1 dB_RestaurantDataSet1;
        private System.Windows.Forms.BindingSource msmenuBindingSource;
        private DB_RestaurantDataSet1TableAdapters.ms_menuTableAdapter ms_menuTableAdapter;
    }
}