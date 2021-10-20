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
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration=Victorina.musicDuration;
        public fGame()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.list.RemoveAt(n);
                lbMelodyCount.Text = Victorina.list.Count.ToString();
            }      
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lbMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lbMusicDuration.Text = musicDuration.ToString();
        }
        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lbMusicDuration.Text = musicDuration.ToString();
            if(progressBar1.Value==progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0) MakeMusic();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GameContinue();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
        void GameContinue()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                GamePause();
                if (MessageBox.Show("Правильный ответ?","Игрок 1",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    lbCounter1.Text = Convert.ToString(Convert.ToInt32(lbCounter1.Text) + 1);
                    MakeMusic();
                }
                GameContinue();
            }
            if (e.KeyData == Keys.L)
            {
                GamePause();
                if (MessageBox.Show("Правильный ответ?", "Игрок 2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbCounter2.Text = Convert.ToString(Convert.ToInt32(lbCounter2.Text) + 1);
                    MakeMusic();
                }
                GameContinue();
            }
        }
    }
}
