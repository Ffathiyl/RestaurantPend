namespace Restaurant
{
    partial class TambahMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMinuman = new System.Windows.Forms.RadioButton();
            this.rbMakanan = new System.Windows.Forms.RadioButton();
            this.richTextBoxDeskripsi = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tambah Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jenis";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNama.Location = new System.Drawing.Point(530, 147);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(313, 35);
            this.txtNama.TabIndex = 7;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStok.Location = new System.Drawing.Point(530, 449);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 35);
            this.txtStok.TabIndex = 8;
            this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStok_KeyPress);
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHarga.Location = new System.Drawing.Point(530, 398);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(313, 35);
            this.txtHarga.TabIndex = 9;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSimpan.Location = new System.Drawing.Point(358, 563);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(106, 48);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBatal.Location = new System.Drawing.Point(719, 563);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(106, 48);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMinuman);
            this.panel1.Controls.Add(this.rbMakanan);
            this.panel1.Location = new System.Drawing.Point(530, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 46);
            this.panel1.TabIndex = 13;
            // 
            // rbMinuman
            // 
            this.rbMinuman.AutoSize = true;
            this.rbMinuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMinuman.Location = new System.Drawing.Point(174, 3);
            this.rbMinuman.Name = "rbMinuman";
            this.rbMinuman.Size = new System.Drawing.Size(136, 33);
            this.rbMinuman.TabIndex = 1;
            this.rbMinuman.TabStop = true;
            this.rbMinuman.Text = "Minuman";
            this.rbMinuman.UseVisualStyleBackColor = true;
            // 
            // rbMakanan
            // 
            this.rbMakanan.AutoSize = true;
            this.rbMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMakanan.Location = new System.Drawing.Point(3, 3);
            this.rbMakanan.Name = "rbMakanan";
            this.rbMakanan.Size = new System.Drawing.Size(135, 33);
            this.rbMakanan.TabIndex = 0;
            this.rbMakanan.TabStop = true;
            this.rbMakanan.Text = "Makanan";
            this.rbMakanan.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDeskripsi
            // 
            this.richTextBoxDeskripsi.Location = new System.Drawing.Point(530, 210);
            this.richTextBoxDeskripsi.Name = "richTextBoxDeskripsi";
            this.richTextBoxDeskripsi.Size = new System.Drawing.Size(313, 96);
            this.richTextBoxDeskripsi.TabIndex = 14;
            this.richTextBoxDeskripsi.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Deskripsi";
            // 
            // TambahMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxDeskripsi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TambahMenu";
            this.Text = "TambahMenu";
            this.Load += new System.EventHandler(this.TambahMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMakanan;
        private System.Windows.Forms.RadioButton rbMinuman;
        private System.Windows.Forms.RichTextBox richTextBoxDeskripsi;
        private System.Windows.Forms.Label label6;
    }
}