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

        // Do stuff  to correctly shut down the application
        private void VersusMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCGM.Close();
        }

        // Validate the maskedTextBox
        private void buttonValidateWordToFind_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxWordToFind.Text != null && maskedTextBoxWordToFind.Text != "" && maskedTextBoxWordToFind.Text.Length >= 3)
            {
                if (maskedTextBox1.Text != null && maskedTextBox1.Text != "")
                {
                    formSm = new SoloMode(this, maskedTextBoxWordToFind.Text, Convert.ToInt16(maskedTextBox1.Text));
                    Hide();
                    formSm.ShowDialog(); 
                }
            }
            else
            {
                MessageBox.Show(
                    "Le mot entré ne peux pas être inférieur à 3 caractères, sinon ça n'est pas considéré commme un mot !",
                    "Avertissement",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }

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
        
        private void maskedTextBoxWordToFind_TextChanged(object sender, EventArgs e)
        {
            Word.HasValidCharacter(maskedTextBoxWordToFind);
        }        
    }
}
