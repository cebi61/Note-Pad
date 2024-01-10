
namespace GP2_3Ödev._2
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.maddeİşaretleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTümünüSeç = new System.Windows.Forms.ToolStripButton();
            this.btnYakınlaştır = new System.Windows.Forms.ToolStripButton();
            this.btnUzaklaştır = new System.Windows.Forms.ToolStripButton();
            this.lblINS = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNUM = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCAPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSutun = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSatır = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYapıştır = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYinele = new System.Windows.Forms.ToolStripButton();
            this.btnGeriAl = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnAç = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripSplitButton();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYazıTipi = new System.Windows.Forms.ToolStripButton();
            this.cbYazıTipi = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYazıRengi = new System.Windows.Forms.ToolStripButton();
            this.btnVurguRengi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSolaHizala = new System.Windows.Forms.ToolStripButton();
            this.btnOrtala = new System.Windows.Forms.ToolStripButton();
            this.btnSağaHizala = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMaddeİşareti = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGirintiAzalt = new System.Windows.Forms.ToolStripButton();
            this.btnGirintiArttır = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnResimEkle = new System.Windows.Forms.ToolStripButton();
            this.btnSayfaRengi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeğiştir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Zengin Metin Dosyası|*.rtf|Metin Dosyası|*.txt|MYO Metin Dosyası|*.myo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Zengin Metin Dosyası|*.rtf|Metin Dosyası|*.txt|MYO Metin Dosyası|*.myo";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(550, 539);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(118, 22);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(155, 6);
            // 
            // maddeİşaretleriToolStripMenuItem
            // 
            this.maddeİşaretleriToolStripMenuItem.Name = "maddeİşaretleriToolStripMenuItem";
            this.maddeİşaretleriToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.maddeİşaretleriToolStripMenuItem.Text = "Madde İşaretleri";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(155, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.toolStripSeparator14,
            this.tümünüSeçToolStripMenuItem,
            this.toolStripSeparator13,
            this.maddeİşaretleriToolStripMenuItem,
            this.toolStripSeparator12,
            this.yazıTipiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 154);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(155, 6);
            // 
            // btnTümünüSeç
            // 
            this.btnTümünüSeç.CheckOnClick = true;
            this.btnTümünüSeç.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTümünüSeç.Image = global::GP2_3Ödev._2.Properties.Resources.select_all_large_1x1;
            this.btnTümünüSeç.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTümünüSeç.Name = "btnTümünüSeç";
            this.btnTümünüSeç.Size = new System.Drawing.Size(28, 28);
            this.btnTümünüSeç.Text = "Alt Simge";
            this.btnTümünüSeç.ToolTipText = "Tümünü Seç";
            this.btnTümünüSeç.Click += new System.EventHandler(this.btnAltSimge_Click);
            // 
            // btnYakınlaştır
            // 
            this.btnYakınlaştır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYakınlaştır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYakınlaştır.Name = "btnYakınlaştır";
            this.btnYakınlaştır.Size = new System.Drawing.Size(23, 26);
            this.btnYakınlaştır.Text = "Yakınlaştır";
            // 
            // btnUzaklaştır
            // 
            this.btnUzaklaştır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUzaklaştır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUzaklaştır.Name = "btnUzaklaştır";
            this.btnUzaklaştır.Size = new System.Drawing.Size(23, 26);
            this.btnUzaklaştır.Text = "Uzaklaştır";
            // 
            // lblINS
            // 
            this.lblINS.AutoSize = false;
            this.lblINS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblINS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblINS.Name = "lblINS";
            this.lblINS.Size = new System.Drawing.Size(75, 23);
            this.lblINS.Text = "INS";
            // 
            // lblNUM
            // 
            this.lblNUM.AutoSize = false;
            this.lblNUM.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblNUM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNUM.Name = "lblNUM";
            this.lblNUM.Size = new System.Drawing.Size(75, 23);
            this.lblNUM.Text = "NUM";
            // 
            // lblCAPS
            // 
            this.lblCAPS.AutoSize = false;
            this.lblCAPS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblCAPS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCAPS.Name = "lblCAPS";
            this.lblCAPS.Size = new System.Drawing.Size(75, 23);
            this.lblCAPS.Text = "CAPS";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(525, 23);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // lblSutun
            // 
            this.lblSutun.AutoSize = false;
            this.lblSutun.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSutun.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSutun.Name = "lblSutun";
            this.lblSutun.Size = new System.Drawing.Size(100, 23);
            this.lblSutun.Text = "Stn:";
            this.lblSutun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSutun.Click += new System.EventHandler(this.lblSutun_Click);
            // 
            // lblSatır
            // 
            this.lblSatır.AutoSize = false;
            this.lblSatır.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSatır.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatır.Name = "lblSatır";
            this.lblSatır.Size = new System.Drawing.Size(100, 23);
            this.lblSatır.Text = "Str:";
            this.lblSatır.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSatır,
            this.lblSutun,
            this.toolStripStatusLabel4,
            this.lblCAPS,
            this.lblNUM,
            this.lblINS,
            this.lblZoom,
            this.btnUzaklaştır,
            this.btnYakınlaştır});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1064, 28);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblZoom
            // 
            this.lblZoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(44, 23);
            this.lblZoom.Text = "%100";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1064, 477);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnYapıştır
            // 
            this.btnYapıştır.CheckOnClick = true;
            this.btnYapıştır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapıştır.Image = global::GP2_3Ödev._2.Properties.Resources.clipboard_paste_large_1x;
            this.btnYapıştır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapıştır.Name = "btnYapıştır";
            this.btnYapıştır.Size = new System.Drawing.Size(28, 28);
            this.btnYapıştır.Text = "Altı Çizili";
            this.btnYapıştır.ToolTipText = "Yapıştır";
            this.btnYapıştır.Click += new System.EventHandler(this.btnAltıçizili_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.CheckOnClick = true;
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = global::GP2_3Ödev._2.Properties.Resources.clipboard_copy_large_1x;
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(28, 28);
            this.btnKopyala.Text = "Italik";
            this.btnKopyala.ToolTipText = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnItalik_Click);
            // 
            // btnKes
            // 
            this.btnKes.CheckOnClick = true;
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = global::GP2_3Ödev._2.Properties.Resources.clipboard_cut_large_1x;
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(28, 28);
            this.btnKes.Text = "Koyu";
            this.btnKes.ToolTipText = "Kes";
            this.btnKes.Click += new System.EventHandler(this.btnKoyu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // btnYinele
            // 
            this.btnYinele.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYinele.Image = global::GP2_3Ödev._2.Properties.Resources.command_redo_large_1x;
            this.btnYinele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYinele.Name = "btnYinele";
            this.btnYinele.Size = new System.Drawing.Size(28, 28);
            this.btnYinele.Text = "Küçült";
            this.btnYinele.ToolTipText = "Yinele";
            this.btnYinele.Click += new System.EventHandler(this.btnKüçült_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGeriAl.Image = global::GP2_3Ödev._2.Properties.Resources.command_undo_large_1x;
            this.btnGeriAl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(28, 28);
            this.btnGeriAl.Text = "Büyüt";
            this.btnGeriAl.ToolTipText = "Gerial";
            this.btnGeriAl.Click += new System.EventHandler(this.btnBüyüt_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.btnAç,
            this.btnKaydet,
            this.btnGeriAl,
            this.btnYinele,
            this.toolStripSeparator6,
            this.btnKes,
            this.btnKopyala,
            this.btnYapıştır,
            this.toolStripSeparator3,
            this.btnTümünüSeç});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1064, 31);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // btnYeni
            // 
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = global::GP2_3Ödev._2.Properties.Resources.document_text_large_1x;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(28, 28);
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYazıTipi_Click);
            // 
            // btnAç
            // 
            this.btnAç.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAç.Image = global::GP2_3Ödev._2.Properties.Resources.open_large_1x;
            this.btnAç.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAç.Name = "btnAç";
            this.btnAç.Size = new System.Drawing.Size(28, 28);
            this.btnAç.Text = "Aç";
            this.btnAç.Click += new System.EventHandler(this.cbYazıTipi_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = false;
            this.btnKaydet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem});
            this.btnKaydet.Image = global::GP2_3Ödev._2.Properties.Resources.save_large_1x;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(37, 23);
            this.btnKaydet.ButtonClick += new System.EventHandler(this.cbYazıBüyüklüğü_ButtonClick);
            this.btnKaydet.Click += new System.EventHandler(this.cbYazıBüyüklüğü_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Image = global::GP2_3Ödev._2.Properties.Resources.save_as_large_1x;
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fToolStripMenuItem.Text = "Farklı Kaydet";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYazıTipi,
            this.cbYazıTipi,
            this.toolStripSeparator1,
            this.btnYazıRengi,
            this.btnVurguRengi,
            this.toolStripSeparator5,
            this.btnSolaHizala,
            this.btnOrtala,
            this.btnSağaHizala,
            this.toolStripSeparator7,
            this.btnMaddeİşareti,
            this.toolStripSeparator8,
            this.btnGirintiAzalt,
            this.btnGirintiArttır,
            this.toolStripSeparator9,
            this.btnResimEkle,
            this.btnSayfaRengi,
            this.toolStripSeparator10,
            this.btnDeğiştir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1064, 31);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnYazıTipi
            // 
            this.btnYazıTipi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYazıTipi.Image = global::GP2_3Ödev._2.Properties.Resources.character_fonts_large_1x;
            this.btnYazıTipi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYazıTipi.Name = "btnYazıTipi";
            this.btnYazıTipi.Size = new System.Drawing.Size(28, 28);
            this.btnYazıTipi.Text = "Yazı Tipi";
            this.btnYazıTipi.Click += new System.EventHandler(this.btnYazıTipi_Click_1);
            // 
            // cbYazıTipi
            // 
            this.cbYazıTipi.Name = "cbYazıTipi";
            this.cbYazıTipi.Size = new System.Drawing.Size(75, 31);
            this.cbYazıTipi.Text = "Yazı Stilleri";
            this.cbYazıTipi.Click += new System.EventHandler(this.cbYazıTipi_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnYazıRengi
            // 
            this.btnYazıRengi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYazıRengi.Image = global::GP2_3Ödev._2.Properties.Resources.character_color_large_1x;
            this.btnYazıRengi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYazıRengi.Name = "btnYazıRengi";
            this.btnYazıRengi.Size = new System.Drawing.Size(28, 28);
            this.btnYazıRengi.Text = "toolStripButton1";
            this.btnYazıRengi.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnVurguRengi
            // 
            this.btnVurguRengi.CheckOnClick = true;
            this.btnVurguRengi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVurguRengi.Image = global::GP2_3Ödev._2.Properties.Resources.character_color_highlight_large_1x1;
            this.btnVurguRengi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVurguRengi.Name = "btnVurguRengi";
            this.btnVurguRengi.Size = new System.Drawing.Size(28, 28);
            this.btnVurguRengi.Text = "toolStripButton5";
            this.btnVurguRengi.Click += new System.EventHandler(this.btnVurguRengi_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSolaHizala
            // 
            this.btnSolaHizala.CheckOnClick = true;
            this.btnSolaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSolaHizala.Image = global::GP2_3Ödev._2.Properties.Resources.paragraph_align_left_small_1x;
            this.btnSolaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSolaHizala.Name = "btnSolaHizala";
            this.btnSolaHizala.Size = new System.Drawing.Size(28, 28);
            this.btnSolaHizala.Text = "toolStripButton6";
            this.btnSolaHizala.Click += new System.EventHandler(this.btnSolaHizala_Click);
            // 
            // btnOrtala
            // 
            this.btnOrtala.CheckOnClick = true;
            this.btnOrtala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrtala.Image = global::GP2_3Ödev._2.Properties.Resources.paragraph_align_center_small_1x;
            this.btnOrtala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrtala.Name = "btnOrtala";
            this.btnOrtala.Size = new System.Drawing.Size(28, 28);
            this.btnOrtala.Text = "toolStripButton7";
            this.btnOrtala.Click += new System.EventHandler(this.btnOrtala_Click);
            // 
            // btnSağaHizala
            // 
            this.btnSağaHizala.CheckOnClick = true;
            this.btnSağaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSağaHizala.Image = global::GP2_3Ödev._2.Properties.Resources.paragraph_align_right_small_1x;
            this.btnSağaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSağaHizala.Name = "btnSağaHizala";
            this.btnSağaHizala.Size = new System.Drawing.Size(28, 28);
            this.btnSağaHizala.Text = "toolStripButton8";
            this.btnSağaHizala.Click += new System.EventHandler(this.btnSağaHizala_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // btnMaddeİşareti
            // 
            this.btnMaddeİşareti.CheckOnClick = true;
            this.btnMaddeİşareti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMaddeİşareti.Image = global::GP2_3Ödev._2.Properties.Resources.list_bullets_large_1x;
            this.btnMaddeİşareti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaddeİşareti.Name = "btnMaddeİşareti";
            this.btnMaddeİşareti.Size = new System.Drawing.Size(28, 28);
            this.btnMaddeİşareti.Text = "toolStripButton9";
            this.btnMaddeİşareti.Click += new System.EventHandler(this.btnMaddeİşareti_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // btnGirintiAzalt
            // 
            this.btnGirintiAzalt.CheckOnClick = true;
            this.btnGirintiAzalt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGirintiAzalt.Image = global::GP2_3Ödev._2.Properties.Resources.paragraph_unindent_left_large_1x;
            this.btnGirintiAzalt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGirintiAzalt.Name = "btnGirintiAzalt";
            this.btnGirintiAzalt.Size = new System.Drawing.Size(28, 28);
            this.btnGirintiAzalt.Text = "toolStripButton11";
            this.btnGirintiAzalt.Click += new System.EventHandler(this.btnGirintiAzalt_Click);
            // 
            // btnGirintiArttır
            // 
            this.btnGirintiArttır.CheckOnClick = true;
            this.btnGirintiArttır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGirintiArttır.Image = global::GP2_3Ödev._2.Properties.Resources.paragraph_indent_left_large_1x;
            this.btnGirintiArttır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGirintiArttır.Name = "btnGirintiArttır";
            this.btnGirintiArttır.Size = new System.Drawing.Size(28, 28);
            this.btnGirintiArttır.Text = "toolStripButton12";
            this.btnGirintiArttır.Click += new System.EventHandler(this.btnGirintiArttır_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.CheckOnClick = true;
            this.btnResimEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnResimEkle.Image = global::GP2_3Ödev._2.Properties.Resources.insert_picture_large_1x;
            this.btnResimEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(28, 28);
            this.btnResimEkle.Text = "toolStripButton13";
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnSayfaRengi
            // 
            this.btnSayfaRengi.CheckOnClick = true;
            this.btnSayfaRengi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSayfaRengi.Image = global::GP2_3Ödev._2.Properties.Resources.colors;
            this.btnSayfaRengi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSayfaRengi.Name = "btnSayfaRengi";
            this.btnSayfaRengi.Size = new System.Drawing.Size(28, 28);
            this.btnSayfaRengi.Text = "toolStripButton14";
            this.btnSayfaRengi.Click += new System.EventHandler(this.btnSayfaRengi_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDeğiştir
            // 
            this.btnDeğiştir.CheckOnClick = true;
            this.btnDeğiştir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeğiştir.Image = global::GP2_3Ödev._2.Properties.Resources.replace_large_1x;
            this.btnDeğiştir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeğiştir.Name = "btnDeğiştir";
            this.btnDeğiştir.Size = new System.Drawing.Size(28, 28);
            this.btnDeğiştir.Text = "toolStripButton16";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem maddeİşaretleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton btnTümünüSeç;
        private System.Windows.Forms.ToolStripButton btnYakınlaştır;
        private System.Windows.Forms.ToolStripButton btnUzaklaştır;
        private System.Windows.Forms.ToolStripStatusLabel lblINS;
        private System.Windows.Forms.ToolStripStatusLabel lblNUM;
        private System.Windows.Forms.ToolStripStatusLabel lblCAPS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblSutun;
        private System.Windows.Forms.ToolStripStatusLabel lblSatır;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblZoom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnYapıştır;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnYinele;
        private System.Windows.Forms.ToolStripButton btnGeriAl;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAç;
        private System.Windows.Forms.ToolStripSplitButton btnKaydet;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYazıTipi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnVurguRengi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSolaHizala;
        private System.Windows.Forms.ToolStripButton btnOrtala;
        private System.Windows.Forms.ToolStripButton btnSağaHizala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnMaddeİşareti;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnGirintiAzalt;
        private System.Windows.Forms.ToolStripButton btnGirintiArttır;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnResimEkle;
        private System.Windows.Forms.ToolStripButton btnSayfaRengi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnDeğiştir;
        private System.Windows.Forms.ToolStripComboBox cbYazıTipi;
        private System.Windows.Forms.ToolStripButton btnYazıRengi;
    }
}

