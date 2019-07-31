namespace WifiJammer
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSBtnTaramaBaslat = new System.Windows.Forms.ToolStripMenuItem();
            this.taramayıDurdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSBtnCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TBBtnTara = new System.Windows.Forms.ToolStripButton();
            this.TBBtnDurdur = new System.Windows.Forms.ToolStripButton();
            this.TBBtnHSec = new System.Windows.Forms.ToolStripButton();
            this.TBBtnAt = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtBaslangic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtnTaramaBaslat,
            this.taramayıDurdurToolStripMenuItem,
            this.TSBtnCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSBtnTaramaBaslat
            // 
            this.TSBtnTaramaBaslat.Name = "TSBtnTaramaBaslat";
            this.TSBtnTaramaBaslat.Size = new System.Drawing.Size(193, 26);
            this.TSBtnTaramaBaslat.Text = "Taramayı Başlat";
            this.TSBtnTaramaBaslat.Click += new System.EventHandler(this.TSBtnTaramaBaslat_Click);
            // 
            // taramayıDurdurToolStripMenuItem
            // 
            this.taramayıDurdurToolStripMenuItem.Name = "taramayıDurdurToolStripMenuItem";
            this.taramayıDurdurToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.taramayıDurdurToolStripMenuItem.Text = "Taramayı Durdur";
            // 
            // TSBtnCikis
            // 
            this.TSBtnCikis.Name = "TSBtnCikis";
            this.TSBtnCikis.Size = new System.Drawing.Size(193, 26);
            this.TSBtnCikis.Text = "Çıkış";
            this.TSBtnCikis.Click += new System.EventHandler(this.TSBtnCikis_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBBtnTara,
            this.TBBtnDurdur,
            this.TBBtnHSec,
            this.TBBtnAt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TBBtnTara
            // 
            this.TBBtnTara.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBBtnTara.Image = ((System.Drawing.Image)(resources.GetObject("TBBtnTara.Image")));
            this.TBBtnTara.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBBtnTara.Name = "TBBtnTara";
            this.TBBtnTara.Size = new System.Drawing.Size(24, 24);
            this.TBBtnTara.Text = "Tara";
            this.TBBtnTara.Click += new System.EventHandler(this.TBBtnTara_Click);
            // 
            // TBBtnDurdur
            // 
            this.TBBtnDurdur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBBtnDurdur.Image = ((System.Drawing.Image)(resources.GetObject("TBBtnDurdur.Image")));
            this.TBBtnDurdur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBBtnDurdur.Name = "TBBtnDurdur";
            this.TBBtnDurdur.Size = new System.Drawing.Size(24, 24);
            this.TBBtnDurdur.Text = "Durdur";
            this.TBBtnDurdur.Click += new System.EventHandler(this.TBBtnDurdur_Click);
            // 
            // TBBtnHSec
            // 
            this.TBBtnHSec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBBtnHSec.Image = ((System.Drawing.Image)(resources.GetObject("TBBtnHSec.Image")));
            this.TBBtnHSec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBBtnHSec.Name = "TBBtnHSec";
            this.TBBtnHSec.Size = new System.Drawing.Size(24, 24);
            this.TBBtnHSec.Text = "HepsiniSec";
            this.TBBtnHSec.Click += new System.EventHandler(this.TBBtnHSec_Click);
            // 
            // TBBtnAt
            // 
            this.TBBtnAt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBBtnAt.Image = ((System.Drawing.Image)(resources.GetObject("TBBtnAt.Image")));
            this.TBBtnAt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBBtnAt.Name = "TBBtnAt";
            this.TBBtnAt.Size = new System.Drawing.Size(24, 24);
            this.TBBtnAt.Text = "WifidenAt";
            this.TBBtnAt.Click += new System.EventHandler(this.TBBtnAt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // TxtBaslangic
            // 
            this.TxtBaslangic.Enabled = false;
            this.TxtBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBaslangic.Location = new System.Drawing.Point(342, 64);
            this.TxtBaslangic.Multiline = true;
            this.TxtBaslangic.Name = "TxtBaslangic";
            this.TxtBaslangic.Size = new System.Drawing.Size(130, 30);
            this.TxtBaslangic.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(230, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Adresim";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(69, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(620, 406);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 36);
            this.listBox1.TabIndex = 7;
            this.listBox1.Visible = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBaslangic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WifiJammer";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSBtnCikis;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TBBtnTara;
        private System.Windows.Forms.ToolStripButton TBBtnDurdur;
        private System.Windows.Forms.ToolStripButton TBBtnHSec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton TBBtnAt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem TSBtnTaramaBaslat;
        private System.Windows.Forms.ToolStripMenuItem taramayıDurdurToolStripMenuItem;
    }
}

