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
    public partial class SoloMode : Form
    {
        // Global Variables
        ChooseGameMode formCGM;
        VersusMode formVM;
        string wordToFind;
        public SoloMode(object cgm)
        {
            InitializeComponent();
            formCGM = (ChooseGameMode)cgm;
        }
        public SoloMode(object vm, string wordToFind)
        {
            InitializeComponent();
            formVM = (VersusMode)vm;
            this.wordToFind = wordToFind;

        }

        private void buttonValidationWord_Click(object sender, EventArgs e)
        {
            // Get the word enter
            string wordToVerify = textBoxWordToFind.Text;

            if(wordToVerify == wordToFind)
            {
                MessageBox.Show(
                    "! ! ! Vous avez trouvé le mot ! ! !",
                    "Félicitations",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                // To be implemented with a tooltip
            }
        }

        // Check on each changement on the textBox if the character enter is valid.
        private void textBoxWordToFind_TextChanged(object sender, EventArgs e)
        {
            Word.HasValidCharacter(textBoxWordToFind);
        }

        // Do stuff  to correctly shut down the application
        private void SoloMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(formCGM != null)
            {
                formCGM.Close();
            }
            if(formVM != null)
            {
                formVM.Close();
            }
            Dispose();
        }
        
        // Perform a click when button Enter is press on the keyboard
        private void textBoxWordToFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonValidationWord.PerformClick();
            }
        }
    }
}
