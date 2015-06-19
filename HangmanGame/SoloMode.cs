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
        private List<char> Letters = new List<char>
        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-'};
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
            // To be implemented, the word must be checked regarding the word to find.
        }

        private void textBoxWordToFind_TextChanged(object sender, EventArgs e)
        {
            // Shortcut to textbox length
            int tbLength = textBoxWordToFind.Text.Length;
            // Check if the textbox is not empty
            if (tbLength != 0)
            {
                // Check if the last caracter is one the allowed
                if (!Letters.Contains(textBoxWordToFind.Text.Last()))
                {
                    string enumAllow = "";
                    Letters.ForEach(delegate (char citem)
                    {
                        enumAllow += citem.ToString() + " | ";
                    });
                    textBoxWordToFind.Text = textBoxWordToFind.Text.Remove(tbLength - 1, 1);
                    textBoxWordToFind.Select(tbLength, 0);
                    MessageBox.Show("Le dernier caractère entré n'est pas valide. Il doit être un de ceux là : " + enumAllow, "Erreur de caractère", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

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
        private void buttonValidationWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonValidationWord.PerformClick();
            }
        }
    }
}
