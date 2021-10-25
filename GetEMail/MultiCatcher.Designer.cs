namespace GetEMail
{
    partial class MultiCatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiCatcher));
            this.cmsLink = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsLink_Ardisik = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSiteler = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstEpostalar = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEPSecSil = new System.Windows.Forms.Button();
            this.btnEPTemizle = new System.Windows.Forms.Button();
            this.btnEPKaydet = new System.Windows.Forms.Button();
            this.btnTNSecSil = new System.Windows.Forms.Button();
            this.btnTNTemizle = new System.Windows.Forms.Button();
            this.btnTNKaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstTelNumaralari = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnIptal = new System.Windows.Forms.Button();
            this.prgIlerleme = new System.Windows.Forms.ProgressBar();
            this.btnBul = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.bwBul = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnArdSayfaEkle = new System.Windows.Forms.ToolStripButton();
            this.btnHakkinda = new System.Windows.Forms.ToolStripButton();
            this.cmsLink.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsLink
            // 
            this.cmsLink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsLink_Ardisik});
            this.cmsLink.Name = "cmsLink";
            this.cmsLink.Size = new System.Drawing.Size(166, 26);
            // 
            // cmsLink_Ardisik
            // 
            this.cmsLink_Ardisik.Name = "cmsLink_Ardisik";
            this.cmsLink_Ardisik.Size = new System.Drawing.Size(165, 22);
            this.cmsLink_Ardisik.Text = "Ardışık Sayfa Ekle";
            this.cmsLink_Ardisik.Click += new System.EventHandler(this.cmsLink_Ardisik_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSiteler);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aranacak Siteler";
            // 
            // txtSiteler
            // 
            this.txtSiteler.ContextMenuStrip = this.cmsLink;
            this.txtSiteler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSiteler.Location = new System.Drawing.Point(3, 16);
            this.txtSiteler.Multiline = true;
            this.txtSiteler.Name = "txtSiteler";
            this.txtSiteler.Size = new System.Drawing.Size(794, 101);
            this.txtSiteler.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstEpostalar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 296);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bulunan E-Postalar";
            // 
            // lstEpostalar
            // 
            this.lstEpostalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEpostalar.FormattingEnabled = true;
            this.lstEpostalar.Location = new System.Drawing.Point(3, 16);
            this.lstEpostalar.Name = "lstEpostalar";
            this.lstEpostalar.Size = new System.Drawing.Size(264, 277);
            this.lstEpostalar.TabIndex = 0;
            this.lstEpostalar.SelectedIndexChanged += new System.EventHandler(this.lstEpostalar_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEPSecSil);
            this.splitContainer1.Panel1.Controls.Add(this.btnEPTemizle);
            this.splitContainer1.Panel1.Controls.Add(this.btnEPKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTNSecSil);
            this.splitContainer1.Panel2.Controls.Add(this.btnTNTemizle);
            this.splitContainer1.Panel2.Controls.Add(this.btnTNKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 296);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnEPSecSil
            // 
            this.btnEPSecSil.Location = new System.Drawing.Point(276, 74);
            this.btnEPSecSil.Name = "btnEPSecSil";
            this.btnEPSecSil.Size = new System.Drawing.Size(108, 23);
            this.btnEPSecSil.TabIndex = 2;
            this.btnEPSecSil.Text = "<-Seçileni Sil";
            this.btnEPSecSil.UseVisualStyleBackColor = true;
            this.btnEPSecSil.Click += new System.EventHandler(this.btnEPSecSil_Click);
            // 
            // btnEPTemizle
            // 
            this.btnEPTemizle.Location = new System.Drawing.Point(276, 45);
            this.btnEPTemizle.Name = "btnEPTemizle";
            this.btnEPTemizle.Size = new System.Drawing.Size(108, 23);
            this.btnEPTemizle.TabIndex = 1;
            this.btnEPTemizle.Text = "<-Listeyi Temizle";
            this.btnEPTemizle.UseVisualStyleBackColor = true;
            this.btnEPTemizle.Click += new System.EventHandler(this.btnEPTemizle_Click);
            // 
            // btnEPKaydet
            // 
            this.btnEPKaydet.Location = new System.Drawing.Point(276, 16);
            this.btnEPKaydet.Name = "btnEPKaydet";
            this.btnEPKaydet.Size = new System.Drawing.Size(108, 23);
            this.btnEPKaydet.TabIndex = 0;
            this.btnEPKaydet.Text = "<-Listeyi Kaydet";
            this.btnEPKaydet.UseVisualStyleBackColor = true;
            this.btnEPKaydet.Click += new System.EventHandler(this.btnEPKaydet_Click);
            // 
            // btnTNSecSil
            // 
            this.btnTNSecSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTNSecSil.Location = new System.Drawing.Point(23, 74);
            this.btnTNSecSil.Name = "btnTNSecSil";
            this.btnTNSecSil.Size = new System.Drawing.Size(108, 23);
            this.btnTNSecSil.TabIndex = 2;
            this.btnTNSecSil.Text = "Seçileni Sil->";
            this.btnTNSecSil.UseVisualStyleBackColor = true;
            this.btnTNSecSil.Click += new System.EventHandler(this.btnTNSecSil_Click);
            // 
            // btnTNTemizle
            // 
            this.btnTNTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTNTemizle.Location = new System.Drawing.Point(23, 45);
            this.btnTNTemizle.Name = "btnTNTemizle";
            this.btnTNTemizle.Size = new System.Drawing.Size(108, 23);
            this.btnTNTemizle.TabIndex = 1;
            this.btnTNTemizle.Text = "Listeyi Temizle->";
            this.btnTNTemizle.UseVisualStyleBackColor = true;
            this.btnTNTemizle.Click += new System.EventHandler(this.btnTNTemizle_Click);
            // 
            // btnTNKaydet
            // 
            this.btnTNKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTNKaydet.Location = new System.Drawing.Point(23, 16);
            this.btnTNKaydet.Name = "btnTNKaydet";
            this.btnTNKaydet.Size = new System.Drawing.Size(108, 23);
            this.btnTNKaydet.TabIndex = 0;
            this.btnTNKaydet.Text = "Listeyi Kaydet->";
            this.btnTNKaydet.UseVisualStyleBackColor = true;
            this.btnTNKaydet.Click += new System.EventHandler(this.btnTNKaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstTelNumaralari);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(137, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 296);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bulunan Telefon Numaraları";
            // 
            // lstTelNumaralari
            // 
            this.lstTelNumaralari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTelNumaralari.FormattingEnabled = true;
            this.lstTelNumaralari.Location = new System.Drawing.Point(3, 16);
            this.lstTelNumaralari.Name = "lstTelNumaralari";
            this.lstTelNumaralari.Size = new System.Drawing.Size(266, 277);
            this.lstTelNumaralari.TabIndex = 0;
            this.lstTelNumaralari.SelectedIndexChanged += new System.EventHandler(this.lstTelNumaralari_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnIptal);
            this.splitContainer2.Panel1.Controls.Add(this.prgIlerleme);
            this.splitContainer2.Panel1.Controls.Add(this.btnBul);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 454);
            this.splitContainer2.SplitterDistance = 154;
            this.splitContainer2.TabIndex = 4;
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Enabled = false;
            this.btnIptal.Location = new System.Drawing.Point(720, 127);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // prgIlerleme
            // 
            this.prgIlerleme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgIlerleme.Location = new System.Drawing.Point(159, 127);
            this.prgIlerleme.Name = "prgIlerleme";
            this.prgIlerleme.Size = new System.Drawing.Size(555, 23);
            this.prgIlerleme.TabIndex = 2;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(12, 126);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(141, 25);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Web Sayfalarında Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "ssMain";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(148, 17);
            this.toolStripStatusLabel1.Text = "Durum : İşlem bekleniyor...";
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 10000;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // bwBul
            // 
            this.bwBul.WorkerReportsProgress = true;
            this.bwBul.WorkerSupportsCancellation = true;
            this.bwBul.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBul_DoWork);
            this.bwBul.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwBul_ProgressChanged);
            this.bwBul.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBul_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArdSayfaEkle,
            this.btnHakkinda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnArdSayfaEkle
            // 
            this.btnArdSayfaEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnArdSayfaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnArdSayfaEkle.Image")));
            this.btnArdSayfaEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArdSayfaEkle.Name = "btnArdSayfaEkle";
            this.btnArdSayfaEkle.Size = new System.Drawing.Size(102, 22);
            this.btnArdSayfaEkle.Text = "Ardışık Sayfa Ekle";
            this.btnArdSayfaEkle.Click += new System.EventHandler(this.btnArdSayfaEkle_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHakkinda.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkinda.Image")));
            this.btnHakkinda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(110, 22);
            this.btnHakkinda.Text = "Program Hakkında";
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // MultiCatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiCatcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiCatcher";
            this.cmsLink.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstEpostalar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnEPSecSil;
        private System.Windows.Forms.Button btnEPTemizle;
        private System.Windows.Forms.Button btnEPKaydet;
        private System.Windows.Forms.Button btnTNSecSil;
        private System.Windows.Forms.Button btnTNTemizle;
        private System.Windows.Forms.Button btnTNKaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstTelNumaralari;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.ProgressBar prgIlerleme;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer statusTimer;
        private System.ComponentModel.BackgroundWorker bwBul;
        private System.Windows.Forms.ContextMenuStrip cmsLink;
        private System.Windows.Forms.ToolStripMenuItem cmsLink_Ardisik;
        private System.Windows.Forms.TextBox txtSiteler;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnArdSayfaEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ToolStripButton btnHakkinda;
    }
}