using System;
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
    public partial class VersusMode : Form
    {
        // Global Variables
        ChooseGameMode formCGM;
        SoloMode formSm;
        public VersusMode(ChooseGameMode cgm)
        {
            InitializeComponent();
            formCGM = cgm;
        }

        private void buttonValidateWordToFind_Click(object sender, EventArgs e)
        {
            formSm = new SoloMode(this, maskedTextBoxWordToFind.Text);
            Hide();
            formSm.ShowDialog();

        }

        // Perform a click when button Enter is press on the keyboard
        private void maskedTextBoxWordToFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonValidateWordToFind.PerformClick();
            }
        }

        private void VersusMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCGM.Close();
        }
    }
}
