using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void hakkimdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ömer KOCAMAN\nomr_kcmn@outlook.com");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arama Yapılacak");
        }

        private void toolCounter_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolCounter.Text = listView1.Items.Count.ToString();
        }

        private void torrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Torrent torrent = new Torrent();
            torrent.Show();
        }
    }
}
