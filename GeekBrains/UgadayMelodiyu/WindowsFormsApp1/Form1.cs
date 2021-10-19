using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgadayMelodiyu
{
    public partial class fMain : Form
    {

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParam_Click(object sender, EventArgs e)
        {
            fPr fp = new fPr();
            fp.ShowDialog();
        }
    }
}
