namespace Restaurant.FormMaster
{
    partial class MasterMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgAkun = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mnuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnunamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnudeskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnujenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnustokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnustatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RestaurantDataSet1 = new Restaurant.DB_RestaurantDataSet1();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdeskripsi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtharga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbjenis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RestaurantDataSet = new Restaurant.DB_RestaurantDataSet();
            this.dBRestaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ms_menuTableAdapter = new Restaurant.DB_RestaurantDataSet1TableAdapters.ms_menuTableAdapter();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTambah = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRestaurantDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.dgAkun);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1651, 545);
            this.panel3.TabIndex = 34;
            // 
            // dgAkun
            // 
            this.dgAkun.AllowUserToAddRows = false;
            this.dgAkun.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgAkun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgAkun.AutoGenerateColumns = false;
            this.dgAkun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAkun.BackgroundColor = System.Drawing.Color.White;
            this.dgAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAkun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAkun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAkun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgAkun.ColumnHeadersHeight = 28;
            this.dgAkun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mnuidDataGridViewTextBoxColumn,
            this.mnunamaDataGridViewTextBoxColumn,
            this.mnudeskripsiDataGridViewTextBoxColumn,
            this.mnujenisDataGridViewTextBoxColumn,
            this.mnuhargaDataGridViewTextBoxColumn,
            this.mnustokDataGridViewTextBoxColumn,
            this.mnustatusDataGridViewTextBoxColumn});
            this.dgAkun.DataSource = this.msmenuBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAkun.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgAkun.EnableHeadersVisualStyles = false;
            this.dgAkun.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.dgAkun.Location = new System.Drawing.Point(114, 133);
            this.dgAkun.Name = "dgAkun";
            this.dgAkun.ReadOnly = true;
            this.dgAkun.RowHeadersVisible = false;
            this.dgAkun.RowHeadersWidth = 51;
            this.dgAkun.RowTemplate.Height = 24;
            this.dgAkun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAkun.Size = new System.Drawing.Size(1400, 380);
            this.dgAkun.TabIndex = 0;
            this.dgAkun.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgAkun.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgAkun.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgAkun.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgAkun.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgAkun.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgAkun.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgAkun.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.dgAkun.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgAkun.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAkun.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgAkun.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgAkun.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgAkun.ThemeStyle.HeaderStyle.Height = 28;
            this.dgAkun.ThemeStyle.ReadOnly = true;
            this.dgAkun.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgAkun.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAkun.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgAkun.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgAkun.ThemeStyle.RowsStyle.Height = 24;
            this.dgAkun.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgAkun.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgAkun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAkun_CellClick);
            // 
            // mnuidDataGridViewTextBoxColumn
            // 
            this.mnuidDataGridViewTextBoxColumn.DataPropertyName = "mnu_id";
            this.mnuidDataGridViewTextBoxColumn.HeaderText = "mnu_id";
            this.mnuidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnuidDataGridViewTextBoxColumn.Name = "mnuidDataGridViewTextBoxColumn";
            this.mnuidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnunamaDataGridViewTextBoxColumn
            // 
            this.mnunamaDataGridViewTextBoxColumn.DataPropertyName = "mnu_nama";
            this.mnunamaDataGridViewTextBoxColumn.HeaderText = "mnu_nama";
            this.mnunamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnunamaDataGridViewTextBoxColumn.Name = "mnunamaDataGridViewTextBoxColumn";
            this.mnunamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnudeskripsiDataGridViewTextBoxColumn
            // 
            this.mnudeskripsiDataGridViewTextBoxColumn.DataPropertyName = "mnu_deskripsi";
            this.mnudeskripsiDataGridViewTextBoxColumn.HeaderText = "mnu_deskripsi";
            this.mnudeskripsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnudeskripsiDataGridViewTextBoxColumn.Name = "mnudeskripsiDataGridViewTextBoxColumn";
            this.mnudeskripsiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnujenisDataGridViewTextBoxColumn
            // 
            this.mnujenisDataGridViewTextBoxColumn.DataPropertyName = "mnu_jenis";
            this.mnujenisDataGridViewTextBoxColumn.HeaderText = "mnu_jenis";
            this.mnujenisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnujenisDataGridViewTextBoxColumn.Name = "mnujenisDataGridViewTextBoxColumn";
            this.mnujenisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnuhargaDataGridViewTextBoxColumn
            // 
            this.mnuhargaDataGridViewTextBoxColumn.DataPropertyName = "mnu_harga";
            this.mnuhargaDataGridViewTextBoxColumn.HeaderText = "mnu_harga";
            this.mnuhargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnuhargaDataGridViewTextBoxColumn.Name = "mnuhargaDataGridViewTextBoxColumn";
            this.mnuhargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnustokDataGridViewTextBoxColumn
            // 
            this.mnustokDataGridViewTextBoxColumn.DataPropertyName = "mnu_stok";
            this.mnustokDataGridViewTextBoxColumn.HeaderText = "mnu_stok";
            this.mnustokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnustokDataGridViewTextBoxColumn.Name = "mnustokDataGridViewTextBoxColumn";
            this.mnustokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnustatusDataGridViewTextBoxColumn
            // 
            this.mnustatusDataGridViewTextBoxColumn.DataPropertyName = "mnu_status";
            this.mnustatusDataGridViewTextBoxColumn.HeaderText = "mnu_status";
            this.mnustatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnustatusDataGridViewTextBoxColumn.Name = "mnustatusDataGridViewTextBoxColumn";
            this.mnustatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msmenuBindingSource
            // 
            this.msmenuBindingSource.DataMember = "ms_menu";
            this.msmenuBindingSource.DataSource = this.dB_RestaurantDataSet1;
            // 
            // dB_RestaurantDataSet1
            // 
            this.dB_RestaurantDataSet1.DataSetName = "DB_RestaurantDataSet1";
            this.dB_RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.FocusedState.Parent = this.cbStatus;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.HoverState.Parent = this.cbStatus;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(1064, 277);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(354, 36);
            this.cbStatus.TabIndex = 37;
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdeskripsi.DefaultText = "";
            this.txtdeskripsi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdeskripsi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdeskripsi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdeskripsi.DisabledState.Parent = this.txtdeskripsi;
            this.txtdeskripsi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdeskripsi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdeskripsi.FocusedState.Parent = this.txtdeskripsi;
            this.txtdeskripsi.ForeColor = System.Drawing.Color.Black;
            this.txtdeskripsi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdeskripsi.HoverState.Parent = this.txtdeskripsi;
            this.txtdeskripsi.Location = new System.Drawing.Point(1064, 210);
            this.txtdeskripsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.PasswordChar = '\0';
            this.txtdeskripsi.PlaceholderText = "";
            this.txtdeskripsi.SelectedText = "";
            this.txtdeskripsi.ShadowDecoration.Parent = this.txtdeskripsi;
            this.txtdeskripsi.Size = new System.Drawing.Size(354, 39);
            this.txtdeskripsi.TabIndex = 23;
            // 
            // txtstok
            // 
            this.txtstok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstok.DefaultText = "";
            this.txtstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.DisabledState.Parent = this.txtstok;
            this.txtstok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstok.FocusedState.Parent = this.txtstok;
            this.txtstok.ForeColor = System.Drawing.Color.Black;
            this.txtstok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstok.HoverState.Parent = this.txtstok;
            this.txtstok.Location = new System.Drawing.Point(393, 281);
            this.txtstok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstok.Name = "txtstok";
            this.txtstok.PasswordChar = '\0';
            this.txtstok.PlaceholderText = "";
            this.txtstok.SelectedText = "";
            this.txtstok.ShadowDecoration.Parent = this.txtstok;
            this.txtstok.Size = new System.Drawing.Size(354, 39);
            this.txtstok.TabIndex = 22;
            // 
            // txtharga
            // 
            this.txtharga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtharga.DefaultText = "";
            this.txtharga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtharga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtharga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtharga.DisabledState.Parent = this.txtharga;
            this.txtharga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtharga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtharga.FocusedState.Parent = this.txtharga;
            this.txtharga.ForeColor = System.Drawing.Color.Black;
            this.txtharga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtharga.HoverState.Parent = this.txtharga;
            this.txtharga.Location = new System.Drawing.Point(393, 210);
            this.txtharga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtharga.Name = "txtharga";
            this.txtharga.PasswordChar = '\0';
            this.txtharga.PlaceholderText = "";
            this.txtharga.SelectedText = "";
            this.txtharga.ShadowDecoration.Parent = this.txtharga;
            this.txtharga.Size = new System.Drawing.Size(354, 39);
            this.txtharga.TabIndex = 21;
            // 
            // txtnama
            // 
            this.txtnama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnama.DefaultText = "";
            this.txtnama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama.DisabledState.Parent = this.txtnama;
            this.txtnama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama.FocusedState.Parent = this.txtnama;
            this.txtnama.ForeColor = System.Drawing.Color.Black;
            this.txtnama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama.HoverState.Parent = this.txtnama;
            this.txtnama.Location = new System.Drawing.Point(393, 147);
            this.txtnama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnama.Name = "txtnama";
            this.txtnama.PasswordChar = '\0';
            this.txtnama.PlaceholderText = "";
            this.txtnama.SelectedText = "";
            this.txtnama.ShadowDecoration.Parent = this.txtnama;
            this.txtnama.Size = new System.Drawing.Size(354, 39);
            this.txtnama.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(894, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(894, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Deskripsi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stok";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnTambah);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1651, 716);
            this.panel2.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnRefresh.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(1324, 54);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(130, 49);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nama Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbjenis);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txtdeskripsi);
            this.panel1.Controls.Add(this.txtstok);
            this.panel1.Controls.Add(this.txtharga);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1651, 342);
            this.panel1.TabIndex = 3;
            // 
            // cbjenis
            // 
            this.cbjenis.BackColor = System.Drawing.Color.Transparent;
            this.cbjenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbjenis.FocusedColor = System.Drawing.Color.Empty;
            this.cbjenis.FocusedState.Parent = this.cbjenis;
            this.cbjenis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbjenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbjenis.FormattingEnabled = true;
            this.cbjenis.HoverState.Parent = this.cbjenis;
            this.cbjenis.ItemHeight = 30;
            this.cbjenis.Items.AddRange(new object[] {
            "-- Pilih Jenis --",
            "Makanan",
            "Minuman"});
            this.cbjenis.ItemsAppearance.Parent = this.cbjenis;
            this.cbjenis.Location = new System.Drawing.Point(1064, 143);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.ShadowDecoration.Parent = this.cbjenis;
            this.cbjenis.Size = new System.Drawing.Size(354, 36);
            this.cbjenis.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(894, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Jenis";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            // 
            // dB_RestaurantDataSet
            // 
            this.dB_RestaurantDataSet.DataSetName = "DB_RestaurantDataSet";
            this.dB_RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBRestaurantDataSetBindingSource
            // 
            this.dBRestaurantDataSetBindingSource.DataSource = this.dB_RestaurantDataSet;
            this.dBRestaurantDataSetBindingSource.Position = 0;
            // 
            // ms_menuTableAdapter
            // 
            this.ms_menuTableAdapter.ClearBeforeFill = true;
            // 
            // txtid
            // 
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.Parent = this.txtid;
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.FocusedState.Parent = this.txtid;
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.HoverState.Parent = this.txtid;
            this.txtid.Location = new System.Drawing.Point(393, 77);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.ShadowDecoration.Parent = this.txtid;
            this.txtid.Size = new System.Drawing.Size(354, 39);
            this.txtid.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "ID Menu";
            // 
            // btnTambah
            // 
            this.btnTambah.CheckedState.Parent = this.btnTambah;
            this.btnTambah.CustomImages.Parent = this.btnTambah;
            this.btnTambah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnTambah.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.HoverState.Parent = this.btnTambah;
            this.btnTambah.Location = new System.Drawing.Point(230, 54);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.ShadowDecoration.Parent = this.btnTambah;
            this.btnTambah.Size = new System.Drawing.Size(130, 49);
            this.btnTambah.TabIndex = 36;
            this.btnTambah.Text = "Add";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnUpdate.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(396, 54);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(130, 49);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(571, 54);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(130, 49);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(1165, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(130, 49);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(776, 54);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(359, 49);
            this.txtSearch.TabIndex = 42;
            // 
            // MasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 1058);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterMenu";
            this.Text = "MasterMenu";
            this.Load += new System.EventHandler(this.MasterMenu_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRestaurantDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgAkun;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtdeskripsi;
        private Guna.UI2.WinForms.Guna2TextBox txtstok;
        private Guna.UI2.WinForms.Guna2TextBox txtharga;
        private Guna.UI2.WinForms.Guna2TextBox txtnama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbjenis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource dBRestaurantDataSetBindingSource;
        private DB_RestaurantDataSet dB_RestaurantDataSet;
        private DB_RestaurantDataSet1 dB_RestaurantDataSet1;
        private System.Windows.Forms.BindingSource msmenuBindingSource;
        private DB_RestaurantDataSet1TableAdapters.ms_menuTableAdapter ms_menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnunamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnudeskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnujenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnuhargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnustokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnustatusDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnTambah;
    }
}