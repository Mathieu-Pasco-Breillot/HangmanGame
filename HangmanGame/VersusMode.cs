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
        public VersusMode(ChooseGameMode cgm)
        {
            InitializeComponent();
            formCGM = cgm;
        }

        private void buttonValidateWordToFind_Click(object sender, EventArgs e)
        {
            SoloMode sm = new SoloMode(maskedTextBoxWordToFind.Text);
            sm.Show();
            formCGM.Close();

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
    }
}
