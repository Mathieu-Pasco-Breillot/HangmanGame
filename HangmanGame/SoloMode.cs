using System;
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
		/// <summary>
		/// The word to find
		/// </summary>
		private string wordToFind;

		/// <summary>
		/// The id of the word to find
		/// </summary>
		private int idWord;

		/// <summary>
		/// The number of allowed tries to find the word, 8 by default.
		/// </summary>
		private short nbOfTries = 8;

		/// <summary>
		/// The stopwatch to measure the elapsed time as long as the player hasn't win or lose
		/// </summary>
		private Stopwatch timer = new Stopwatch();
		
		/// <summary>
		/// Constructor which take a random word in the database.
		/// </summary>
		public SoloMode()
		{
			InitializeComponent();
			wordToFind = HangmanGame.DBRequests.GetARandomWord(out idWord);
			labelWordToFindLength.Text += wordToFind.Length.ToString();
			dataGridViewWrongLetters.Rows.Clear();
			labelRemainsTries2.Text = nbOfTries.ToString();
			ReplaceWordByInterrogation();
			timerRefreshElapsedTime.Start();
			timer.Start();
		}
		
		/// <summary>
		/// Constructor which take the word entered by the other player and the given number of tries.
		/// </summary>
		/// <param name="wordToFind">The word to find entered by the player</param>
		/// <param name="nbOfTries">The number of tries entered by the player</param>
		public SoloMode(string wordToFind, short nbOfTries)
		{
			InitializeComponent();
			this.wordToFind = wordToFind;
			this.nbOfTries = nbOfTries;
			labelWordToFindLength.Text += this.wordToFind.Length.ToString();
			labelRemainsTries2.Text = nbOfTries.ToString();
			ReplaceWordByInterrogation();
		}

		/// <summary>
		/// Replace the word to find by interrogation word to masked it from the player.
		/// </summary>
		private void ReplaceWordByInterrogation()
		{
			for (int i = 0; i < wordToFind.Length; i++)
			{
				labelWordToFind.Text += "?";
			}
		}

		/// <summary>
		/// Do the procedure when it tries to verify.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
					float finalScore = scoreComputation(HangmanGame.DBRequests.GetWordValue(idWord));
					Score score = new Score(finalScore, nbOfTries, idWord, ref timer);
					score.ShowDialog();
					restart();
				}
				else
				{
					if (nbOfTries == 0)
					{
						timer.Stop();
						timerRefreshElapsedTime.Stop();
						Score score = new Score(wordToFind);
						score.ShowDialog();
						restart();
					}
				}
			}
			textBoxCharacterToVerify.Clear();
		}

		/// <summary>
		/// Check on each modification on the textBox if the character entered is valid.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBoxWordToFind_TextChanged(object sender, EventArgs e)
		{
			Word.HasValidCharacter(textBoxCharacterToVerify);
		}

		/// <summary>
		/// Perform a click when button Enter is press on the keyboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBoxWordToFind_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				buttonValidationWord.PerformClick();
			}
		}

		/// <summary>
		/// Add the given character to the array in order to display it to the player.
		/// </summary>
		/// <param name="c">the character to add to the array</param>
		private void addCharacterToDataGrid(string c)
		{
			dataGridViewWrongLetters.Rows.Add(c);
			dataGridViewWrongLetters.Sort(dataGridViewWrongLetters.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
		}

		/// <summary>
		/// Refresh the label time every 1000 ms
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timerRefreshElapsedTime_Tick(object sender, EventArgs e)
		{
			DisplayTime.displayElapsedTime(timer.Elapsed, labelElapsedTime);
		}

		/// <summary>
		/// Change the hangman picture
		/// </summary>
		/// <param name="tries">Determine which picture must be displayed</param>
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

		/// <summary>
		/// The offline score computation
		/// </summary>
		/// <param name="word">The full word is required to compute the score</param>
		/// <returns></returns>
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
			float finalScore = difficultyLevel * nbOfTries * (1 / (T / 10));
			return finalScore;
		}
		
		/// <summary>
		/// The online score computation
		/// </summary>
		/// <param name="wordValue">The value of the word</param>
		/// <returns></returns>
		private float scoreComputation(float wordValue)
		{
			float T = (timer.ElapsedMilliseconds / 1000);
			return wordValue * nbOfTries * (1 / (T / 10));
		}

		/// <summary>
		/// Reset every things which needs to.
		/// </summary>
		private void restart()
		{
			nbOfTries = 8;
			changeHangmanPicture(nbOfTries);
			labelWordToFind.Text = "";
			labelRemainsTries2.Text = "";
			wordToFind = HangmanGame.DBRequests.GetARandomWord(out idWord);
			labelWordToFindLength.Text = " Longueur du mot à trouver : " + wordToFind.Length.ToString();
			dataGridViewWrongLetters.Rows.Clear();
			labelRemainsTries2.Text = nbOfTries.ToString();
			ReplaceWordByInterrogation();
			timerRefreshElapsedTime.Start();
			timer.Restart();
		}

		/// <summary>
		/// Close correctly the application.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SoloMode_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
