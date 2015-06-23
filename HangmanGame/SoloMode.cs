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
    /// SoloMode class
    /// </summary>
    public partial class SoloMode : Form
    {
        // Global Variables
        ChooseGameMode formCGM;
        VersusMode formVM;
        string wordToFind;
        short nbOfTries = 5;
        /// <summary>
        /// The form constructor which take the previous ChooseGameMode form in parameter.
        /// </summary>
        /// <param name="cgm">The ChooseGameMode form to be close properly.</param>
        public SoloMode(ChooseGameMode cgm)
        {
            InitializeComponent();
            formCGM = cgm;
            wordToFind = Word.PickAWord();
            labelWordToFindLength.Text += wordToFind.Length.ToString();
            nbOfTries = (short)wordToFind.Length;
            labelRemainsTries2.Text = nbOfTries.ToString();
            for (int i = 0; i < wordToFind.Length; i++)
            {
                richTextBoxWordToFind.Text += "?";
            }
        }
        /// <summary>
        /// The form constructor which take the previous VersusMode form in parameter.
        /// </summary>
        /// <param name="vm">The VersusMode form to be close properly.</param>
        /// <param name="wordToFind">The word to find entered by the player</param>
        /// <param name="nbOfTries">The number of tries entered by the player</param>
        public SoloMode(VersusMode vm, string wordToFind, short nbOfTries)
        {
            InitializeComponent();
            formVM = vm;
            this.wordToFind = wordToFind;
            this.nbOfTries = nbOfTries;
            labelWordToFindLength.Text += this.wordToFind.Length.ToString();
            labelRemainsTries2.Text = nbOfTries.ToString();
            for (int i = 0; i < wordToFind.Length; i++)
            {
                richTextBoxWordToFind.Text += "?";
            }
        }

        private void buttonValidationWord_Click(object sender, EventArgs e)
        {
            // Delete one try on each validation call
            nbOfTries--;
            labelRemainsTries2.Text = nbOfTries.ToString();
            // Get the character entered
            string characterToVerify = textBoxCharacterToVerify.Text;
            List<int> foundIndexes = Word.FoundIndexes(characterToVerify, wordToFind);
            Word.InsertTheLetterInsteadOfInterrogation(characterToVerify, foundIndexes, richTextBoxWordToFind);

            if (richTextBoxWordToFind.Text == wordToFind && nbOfTries > 0)
            {
                MessageBox.Show(
                    "! ! ! Vous avez trouvé le mot ! ! !",
                    "Félicitations",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                Dispose();
            }
            else
            {
                if (nbOfTries == 0)
                {
                    MessageBox.Show(
                                "Vous n'avez pas trouvé le mot... \nLe mot à trouver était : " + wordToFind,
                                "C'est dommage",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                    Dispose();
                }
            }
            // Reset the textbox
            textBoxCharacterToVerify.Clear();
        }

        // Check on each changement on the textBox if the character enter is valid.
        private void textBoxWordToFind_TextChanged(object sender, EventArgs e)
        {
            Word.HasValidCharacter(textBoxCharacterToVerify);
        }

        // Do stuff  to correctly shut down the application
        private void SoloMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formCGM != null)
            {
                formCGM.Close();
            }
            if (formVM != null)
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

        // Check on each changement on the pesudoTextBox if the character enter is valid.
        private void pseudoTextBox_TextChanged(object sender, EventArgs e)
        {
            Word.HasValidCharacter(pseudoTextBox);
        }
    }
}
