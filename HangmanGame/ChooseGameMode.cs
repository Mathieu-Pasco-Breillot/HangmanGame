﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    /// <summary>
    /// ChooseGameMode Class
    /// </summary>
    public partial class ChooseGameMode : Form
    {
        /// <summary>
        /// The form constructor which take the previous form in parameter.
        /// </summary>
        public ChooseGameMode()
        {
            InitializeComponent();
        }

        private void buttonSoloMode_Click(object sender, EventArgs e)
        {
            SoloMode sm = new SoloMode(this);
            Hide();
            sm.ShowDialog();
        }

        private void buttonVersusMode_Click(object sender, EventArgs e)
        {
            VersusMode sm = new VersusMode(this);
            Hide();
            sm.ShowDialog();
        }
    }
}
