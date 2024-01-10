using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP2_3Ödev._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnYardım_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = (trackBar1.Value / 100f);
            lblZoom.Text = "%" + richTextBox1.ZoomFactor * 100;
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog() { Filter = "Resim Dosyaları|*.bmp;*.jpg;*.jpeg;*.png;*.gif" };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Image res = Image.FromFile(fd.FileName);
                Clipboard.SetImage(res);

                richTextBox1.Paste();
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnYazıTipi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void YeniBirDosya(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void cbYazıTipi_Click(object sender, EventArgs e)
        {

        }

        private void btnBüyüt_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void btnKüçült_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void btnKoyu_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btnItalik_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btnAltıçizili_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(new DataFormats.Format("", 0));
        }

        private void btnKes_Click(object sender, EventArgs e)
        {

        }

        private void cbYazıBüyüklüğü_ButtonClick(object sender, EventArgs e)
        {

        }

        private void cbYazıBüyüklüğü_Click(object sender, EventArgs e)
        {

        }

        private void btnAltSimge_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }

        private void btnAç_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }

        private void btnYazıTipi_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
            Font eski = richTextBox1.Font;
            richTextBox1.Font = new Font(cbYazıTipi.Text, eski.Size, eski.Style);
        }

        private void btnBüyüt_Click_1(object sender, EventArgs e)
        {

        }

        private void btnYazıRengi_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;

            var sonuç = colorDialog1.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                btnYazıRengi.BackColor = colorDialog1.Color;
            }
        }

        private void btnVurguRengi_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionBackColor;

            var sonuç = colorDialog1.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
                btnVurguRengi.BackColor = colorDialog1.Color;
            }
        }

        private void btnSolaHizala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnOrtala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnSağaHizala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnMaddeİşareti_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void btnGirintiAzalt_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent -= 10;
        }

        private void btnGirintiArttır_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent += 10;
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog() { Filter = "Resim Dosyaları|*.bmp;*.jpg;*.jpeg;*.png;*.gif" };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Image res = Image.FromFile(fd.FileName);
                Clipboard.SetImage(res);

                richTextBox1.Paste();
            }
        }

        private void btnSayfaRengi_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.BackColor;

            var sonuç = colorDialog1.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSutun_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
                ToolStripControlHost h = new ToolStripControlHost(trackBar1);
                statusStrip1.Items.Add(h);
          
        }

        private void cbYazıTipi_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
            Font eski = richTextBox1.Font;
            richTextBox1.Font = new Font(cbYazıTipi.Text, eski.Size, eski.Style);
        }
    }
}
