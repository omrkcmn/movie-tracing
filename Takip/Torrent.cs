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
    public partial class Torrent : Form
    {
        public Torrent()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.pirate-bay.net/search?q=" + txtAra.Text );
        }
    }
}
