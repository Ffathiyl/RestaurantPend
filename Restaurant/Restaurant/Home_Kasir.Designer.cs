namespace Restaurant {
    partial class Home_Kasir {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Kasir));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahMenuToolStripMenuItem,
            this.updateMenuToolStripMenuItem,
            this.pemesananToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // tambahMenuToolStripMenuItem
            // 
            this.tambahMenuToolStripMenuItem.Name = "tambahMenuToolStripMenuItem";
            resources.ApplyResources(this.tambahMenuToolStripMenuItem, "tambahMenuToolStripMenuItem");
            this.tambahMenuToolStripMenuItem.Click += new System.EventHandler(this.tambahMenuToolStripMenuItem_Click);
            // 
            // updateMenuToolStripMenuItem
            // 
            this.updateMenuToolStripMenuItem.Name = "updateMenuToolStripMenuItem";
            resources.ApplyResources(this.updateMenuToolStripMenuItem, "updateMenuToolStripMenuItem");
            this.updateMenuToolStripMenuItem.Click += new System.EventHandler(this.updateMenuToolStripMenuItem_Click);
            // 
            // pemesananToolStripMenuItem
            // 
            this.pemesananToolStripMenuItem.Name = "pemesananToolStripMenuItem";
            resources.ApplyResources(this.pemesananToolStripMenuItem, "pemesananToolStripMenuItem");
            // 
            // Home_Kasir
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home_Kasir";
            this.Load += new System.EventHandler(this.Home_Kasir_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tambahMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemesananToolStripMenuItem;
    }
}