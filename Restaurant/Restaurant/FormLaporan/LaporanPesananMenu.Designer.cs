namespace Restaurant.FormLaporan
{
    partial class LaporanPesananMenu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.trpesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RestaurantDataSet = new Restaurant.DB_RestaurantDataSet();
            this.lpPembelianSnackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dB_RestaurantDataSet1 = new Restaurant.DB_RestaurantDataSet1();
            this.msmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ms_menuTableAdapter = new Restaurant.DB_RestaurantDataSet1TableAdapters.ms_menuTableAdapter();
            this.tr_pesananTableAdapter = new Restaurant.DB_RestaurantDataSetTableAdapters.tr_pesananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trpesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpPembelianSnackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trpesananBindingSource
            // 
            this.trpesananBindingSource.DataMember = "tr_pesanan";
            this.trpesananBindingSource.DataSource = this.dB_RestaurantDataSet;
            // 
            // dB_RestaurantDataSet
            // 
            this.dB_RestaurantDataSet.DataSetName = "DB_RestaurantDataSet";
            this.dB_RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lpPembelianSnackBindingSource
            // 
            this.lpPembelianSnackBindingSource.DataMember = "LpPembelianSnack";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetTransaksi";
            reportDataSource1.Value = this.trpesananBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Restaurant.FormLaporan.ReportTransaksi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(118, 380);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1120, 525);
            this.reportViewer1.TabIndex = 219;
            // 
            // dtAkhir
            // 
            this.dtAkhir.CheckedState.Parent = this.dtAkhir;
            this.dtAkhir.FillColor = System.Drawing.Color.White;
            this.dtAkhir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAkhir.HoverState.Parent = this.dtAkhir;
            this.dtAkhir.Location = new System.Drawing.Point(585, 262);
            this.dtAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAkhir.Name = "dtAkhir";
            this.dtAkhir.ShadowDecoration.Parent = this.dtAkhir;
            this.dtAkhir.Size = new System.Drawing.Size(422, 36);
            this.dtAkhir.TabIndex = 218;
            this.dtAkhir.Value = new System.DateTime(2023, 8, 4, 15, 31, 24, 844);
            // 
            // dtAwal
            // 
            this.dtAwal.CheckedState.Parent = this.dtAwal;
            this.dtAwal.FillColor = System.Drawing.Color.White;
            this.dtAwal.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAwal.HoverState.Parent = this.dtAwal;
            this.dtAwal.Location = new System.Drawing.Point(585, 208);
            this.dtAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtAwal.Name = "dtAwal";
            this.dtAwal.ShadowDecoration.Parent = this.dtAwal;
            this.dtAwal.Size = new System.Drawing.Size(422, 36);
            this.dtAwal.TabIndex = 217;
            this.dtAwal.Value = new System.DateTime(2023, 8, 4, 15, 31, 24, 844);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.CausesValidation = false;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(217)))), ((int)(((byte)(134)))));
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(1067, 235);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(101, 32);
            this.btnSearch.TabIndex = 216;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(490, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(535, 36);
            this.label10.TabIndex = 215;
            this.label10.Text = "LAPORAN TRANSAKSI PEMBELIAN SNACK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 221;
            this.label2.Text = "Tanggal Akhir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 220;
            this.label1.Text = "Tanggal Awal";
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
            // tr_pesananTableAdapter
            // 
            this.tr_pesananTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanPesananMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 917);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtAkhir);
            this.Controls.Add(this.dtAwal);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanPesananMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LaporanPesananMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanPesananMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trpesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpPembelianSnackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RestaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmenuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lpPembelianSnackBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAkhir;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtAwal;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DB_RestaurantDataSet1 dB_RestaurantDataSet1;
        private System.Windows.Forms.BindingSource msmenuBindingSource;
        private DB_RestaurantDataSet1TableAdapters.ms_menuTableAdapter ms_menuTableAdapter;
        private DB_RestaurantDataSet dB_RestaurantDataSet;
        private System.Windows.Forms.BindingSource trpesananBindingSource;
        private DB_RestaurantDataSetTableAdapters.tr_pesananTableAdapter tr_pesananTableAdapter;
    }
}