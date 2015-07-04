﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		short nbOfTries = 8;
		Stopwatch timer = new Stopwatch();
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
			dataGridViewWrongLetters.Rows.Clear();
			labelRemainsTries2.Text = nbOfTries.ToString();
			for (int i = 0; i < wordToFind.Length; i++)
			{
				labelWordToFind.Text += "?";
			}
			timerRefreshElapsedTime.Start();
			timer.Start();
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
				labelWordToFind.Text += "?";
			}
		}

		// Do all the stuff when we try to verify 
		private void buttonValidationWord_Click(object sender, EventArgs e)
		{
			// Get the character entered
			string characterToVerify = textBoxCharacterToVerify.Text;
			if (!isAlreadyTested(characterToVerify) && characterToVerify != "")
			{
				if (!Word.IsContained(characterToVerify, wordToFind) && characterToVerify.Length != 0)
				{
					// Delete one try on each wrong try
					changeHangmanPicture(--nbOfTries);
					labelRemainsTries2.Text = nbOfTries.ToString();
				}
				List<int> foundIndexes = Word.FoundIndexes(characterToVerify, wordToFind);
				Word.InsertTheLetterInsteadOfInterrogation(characterToVerify, foundIndexes, labelWordToFind);

				// Insert the character inside the datagridview
				addCharacterToDataGrid(characterToVerify);

				// Reset the textbox
				textBoxCharacterToVerify.Clear();

				if (labelWordToFind.Text == wordToFind && nbOfTries > 0)
				{
					timer.Stop();
					timerRefreshElapsedTime.Stop();
					float finalScore = scoreComputation(wordToFind);
					MessageBox.Show(
						"! ! ! Vous avez trouvé le mot ! ! !" + "\nVotre score : " + finalScore + " points !" +
						"\nVotre temps : " + displayElapsedTime(timer.Elapsed),
						"Félicitations",
						MessageBoxButtons.OK,
						MessageBoxIcon.Exclamation,
						MessageBoxDefaultButton.Button1);
                    restart();
				}
				else
				{
					if (nbOfTries == 0)
					{
                        timer.Stop();
                        timerRefreshElapsedTime.Stop();
                        MessageBox.Show(
									"Vous n'avez pas trouvé le mot... \nLe mot à trouver était : " + wordToFind,
									"C'est dommage",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error,
									MessageBoxDefaultButton.Button1);
                        restart();
					}
				}
			}
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

		private void addCharacterToDataGrid(string c)
		{
			dataGridViewWrongLetters.Rows.Add(c);
			dataGridViewWrongLetters.Sort(dataGridViewWrongLetters.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
		}

		private void timerRefreshElapsedTime_Tick(object sender, EventArgs e)
		{
			displayElapsedTime(timer.Elapsed, labelElapsedTime);
		}

		private void changeHangmanPicture(int tries)
		{
			switch (tries)
			{
				case 0:
					pictureBoxHangman.Image = Properties.Resources.Hangman8;
					break;
				case 1:
					pictureBoxHangman.Image = Properties.Resources.Hangman7;
					break;
				case 2:
					pictureBoxHangman.Image = Properties.Resources.Hangman6;
					break;
				case 3:
					pictureBoxHangman.Image = Properties.Resources.Hangman5;
					break;
				case 4:
					pictureBoxHangman.Image = Properties.Resources.Hangman4;
					break;
				case 5:
					pictureBoxHangman.Image = Properties.Resources.Hangman3;
					break;
				case 6:
					pictureBoxHangman.Image = Properties.Resources.Hangman2;
					break;
				case 7:
					pictureBoxHangman.Image = Properties.Resources.Hangman1;
					break;
				case 8:
					pictureBoxHangman.Image = Properties.Resources.Hangman0;
					break;
			}
		}

		/// <summary>
		/// Displays the elapsed time in the GUI
		/// Starts when the action on the start button has been triggered
		/// </summary>
		private void displayElapsedTime(TimeSpan ts, Label label)
		{
			string elapsedTime = "";
			if (ts.Hours >= 1)
			{
				elapsedTime = string.Format("{0:00} h {1:00} min {2:00} s", ts.Hours, ts.Minutes, ts.Seconds);
			}
			else if (ts.Minutes >= 1)
			{
				elapsedTime = string.Format("{0:00} min {1:00} s", ts.Minutes, ts.Seconds);
			}
			else
			{
				elapsedTime = string.Format("{0:00} s", ts.Seconds);
			}
			label.Text = "Temps écoulé : " + elapsedTime;
		}
		private string displayElapsedTime(TimeSpan ts)
		{
			string elapsedTime = "";
			if (ts.Hours >= 1)
			{
				elapsedTime = string.Format("{0:00} h {1:00} min {2:00} s", ts.Hours, ts.Minutes, ts.Seconds);
			}
			else if (ts.Minutes >= 1)
			{
				elapsedTime = string.Format("{0:00} min {1:00} s", ts.Minutes, ts.Seconds);
			}
			else
			{
				elapsedTime = string.Format("{0:00} s", ts.Seconds);
			}
			return elapsedTime;
		}

		/// <summary>
		/// Verify if the letter enter has already been tested
		/// </summary>
		/// <param name="characterToVerify">The character entered which needs to be check</param>
		/// <returns></returns>
		private bool isAlreadyTested(string characterToVerify)
		{
			foreach (DataGridViewRow wrongLetter in dataGridViewWrongLetters.Rows)
			{
				if (wrongLetter.Cells[0].Value != null)
				{
					string cellValue = wrongLetter.Cells[0].Value.ToString();
					if (cellValue != null && cellValue != "" && characterToVerify == cellValue)
					{
						return true;
					}
				}
			}
			return false;
		}

		private float scoreComputation(string word)
		{
			float S = 0, coef = 1, T = (timer.ElapsedMilliseconds / 1000);
			// Do the maths to get the word value
			S = Word.SumLettersByPresence(word);
			// Count the number of vowels and consonants
			Word.CountNbVowelsConsonants(word);
			if (Word.NbConsonants > Word.NbVowels)
			{
				coef = 1.3F;
			}
			else
			{
				coef = 0.75F;
			}
			float difficultyLevel = S * coef;
			float finalScore = difficultyLevel * nbOfTries * (1 / (T/10));
            return finalScore;
		}

        private void restart()
        {
            nbOfTries = 8;
            changeHangmanPicture(nbOfTries);
            labelWordToFind.Text = "";
            labelRemainsTries2.Text = "";
            wordToFind = Word.PickAWord();
            labelWordToFindLength.Text =  " Longueur du mot à trouver : " + wordToFind.Length.ToString();
            dataGridViewWrongLetters.Rows.Clear();
            labelRemainsTries2.Text = nbOfTries.ToString();
            for (int i = 0; i < wordToFind.Length; i++)
            {
                labelWordToFind.Text += "?";
            }
            timerRefreshElapsedTime.Start();
            timer.Restart();
        }
    }
}
