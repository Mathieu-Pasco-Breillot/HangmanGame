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
			//nbOfTries = (short)wordToFind.Length;
			labelRemainsTries2.Text = nbOfTries.ToString();
			for (int i = 0; i < wordToFind.Length; i++)
			{
				richTextBoxWordToFind.Text += "?";
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
				richTextBoxWordToFind.Text += "?";
			}
		}

		// Do all the stuff when we try to verify 
		private void buttonValidationWord_Click(object sender, EventArgs e)
		{
			// Get the character entered
			string characterToVerify = textBoxCharacterToVerify.Text;
			if (!Word.IsContained(characterToVerify, wordToFind) && characterToVerify.Length != 0)
			{
				// Delete one try on each wrong try
				changeHangmanPicture(--nbOfTries);
				labelRemainsTries2.Text = nbOfTries.ToString();
			}
			List<int> foundIndexes = Word.FoundIndexes(characterToVerify, wordToFind);
			Word.InsertTheLetterInsteadOfInterrogation(characterToVerify, foundIndexes, richTextBoxWordToFind);

			// Insert the character inside the datagridview
			addCharacterToDataGrid(characterToVerify);

			// Reset the textbox
			textBoxCharacterToVerify.Clear();

			if (richTextBoxWordToFind.Text == wordToFind && nbOfTries > 0)
			{
				timer.Stop();
				timerRefreshElapsedTime.Stop();
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

		private void displayElapsedTime(ref Stopwatch timer, ref Label labelElapsedTime)
		{
			long time = timer.ElapsedMilliseconds;
			labelElapsedTime.Text = "Temps écoulé : " + time;
		}

		private void timerRefreshElapsedTime_Tick(object sender, EventArgs e)
		{
			displayElapsedTime(ref timer, ref labelElapsedTime);
		}

		private void changeHangmanPicture(int tries)
		{
			switch(tries)
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
	}
}
