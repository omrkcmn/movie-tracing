using System.Windows.Forms;

namespace Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("IMDB: 9.2", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("IMDB: 8.9", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.toolCounter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altyazıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkimdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            listViewItem1.Tag = "1";
            listViewItem2.IndentCount = 1;
            listViewItem2.Tag = "2";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.ımageList1;
            this.listView1.Location = new System.Drawing.Point(12, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1246, 652);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arrival_ver12_xlg.jpg");
            this.ımageList1.Images.SetKeyName(1, "e117df88c147e3a2ddb4ea74044213a2.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.iletişimToolStripMenuItem,
            this.ayarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1270, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolCounter,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 722);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1270, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Ara";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(434, 40);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // toolCounter
            // 
            this.toolCounter.Name = "toolCounter";
            this.toolCounter.Size = new System.Drawing.Size(86, 22);
            this.toolCounter.Text = "toolStripLabel1";
            this.toolCounter.Click += new System.EventHandler(this.toolCounter_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Kütüphanenizde";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel2.Text = "adet içerik var.";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmlerToolStripMenuItem,
            this.dizilerToolStripMenuItem,
            this.altyazıToolStripMenuItem,
            this.torrentToolStripMenuItem});
            this.dosyaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dosyaToolStripMenuItem.Image")));
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filmlerToolStripMenuItem.Image")));
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmlerToolStripMenuItem.Text = "Filmler";
            // 
            // dizilerToolStripMenuItem
            // 
            this.dizilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dizilerToolStripMenuItem.Image")));
            this.dizilerToolStripMenuItem.Name = "dizilerToolStripMenuItem";
            this.dizilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dizilerToolStripMenuItem.Text = "Diziler";
            // 
            // altyazıToolStripMenuItem
            // 
            this.altyazıToolStripMenuItem.Image = global::Takip.Properties.Resources.google_sheets;
            this.altyazıToolStripMenuItem.Name = "altyazıToolStripMenuItem";
            this.altyazıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altyazıToolStripMenuItem.Text = "Altyazı";
            // 
            // torrentToolStripMenuItem
            // 
            this.torrentToolStripMenuItem.Image = global::Takip.Properties.Resources.torrent;
            this.torrentToolStripMenuItem.Name = "torrentToolStripMenuItem";
            this.torrentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.torrentToolStripMenuItem.Text = "Torrent";
            this.torrentToolStripMenuItem.Click += new System.EventHandler(this.torrentToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkimdaToolStripMenuItem});
            this.iletişimToolStripMenuItem.Image = global::Takip.Properties.Resources.info;
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            // 
            // hakkimdaToolStripMenuItem
            // 
            this.hakkimdaToolStripMenuItem.Image = global::Takip.Properties.Resources.info;
            this.hakkimdaToolStripMenuItem.Name = "hakkimdaToolStripMenuItem";
            this.hakkimdaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.hakkimdaToolStripMenuItem.Text = "Hakkımda";
            this.hakkimdaToolStripMenuItem.Click += new System.EventHandler(this.hakkimdaToolStripMenuItem_Click);
            // 
            // ayarToolStripMenuItem
            // 
            this.ayarToolStripMenuItem.Image = global::Takip.Properties.Resources.settings;
            this.ayarToolStripMenuItem.Name = "ayarToolStripMenuItem";
            this.ayarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ayarToolStripMenuItem.Text = "Ayarlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 747);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private Button btnAra;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem filmlerToolStripMenuItem;
        private ToolStripMenuItem dizilerToolStripMenuItem;
        private ToolStripMenuItem altyazıToolStripMenuItem;
        private ToolStripMenuItem torrentToolStripMenuItem;
        private ToolStripMenuItem iletişimToolStripMenuItem;
        private ToolStripMenuItem hakkimdaToolStripMenuItem;
        private ToolStripMenuItem ayarToolStripMenuItem;
        private ToolStripLabel toolCounter;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
    }
}

