﻿using System;
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
        fParam fp = new fParam();
        fGame fg = new fGame();

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMusic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fp.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fg.ShowDialog();
        }
    }
}
