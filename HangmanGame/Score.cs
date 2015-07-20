using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HangmanGame
{
	public partial class Score : Form
	{
		/// <summary>
		/// The score compute after the game is over
		/// </summary>
		private float finalScore;

		/// <summary>
		/// The number of tries remaining after the game is over
		/// </summary>
		private int nbOfTries;

		/// <summary>
		/// The id of the played word
		/// </summary>
		private int idWord;

		/// <summary>
		/// The constructor when the game is won
		/// </summary>
		/// <param name="finalScore"></param>
		/// <param name="nbOfTries"></param>
		/// <param name="idWord"></param>
		/// <param name="timer"></param>
		public Score(float finalScore, int nbOfTries, int idWord, ref Stopwatch timer)
		{
			this.finalScore = finalScore;
			this.nbOfTries = nbOfTries;
			this.idWord = idWord;
			InitializeComponent();
			this.Text = "Félicitations !";
			this.labelFinal.Text = "! ! ! Vous avez trouvé le mot ! ! !" + "\nVotre score : " + finalScore + " points !" + "\nVotre temps : " + DisplayTime.displayElapsedTime(timer.Elapsed);
		}

		/// <summary>
		/// The constructor when the game is lost
		/// </summary>
		/// <param name="wordToFind"></param>
		public Score(string wordToFind)
		{
			InitializeComponent();
			this.Text = "C'est dommage...";
			this.labelFinal.Text = "Vous n'avez pas trouvé le mot... \nLe mot à trouver était : " + wordToFind;
			this.buttonSaveRestart.Enabled = false;
		}

		/// <summary>
		/// Perform a click when button Enter is press on the keyboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pseudoTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (pseudoTextBox.Text != "" && pseudoTextBox.TextLength > 3)
			{
				if (e.KeyChar == (char)Keys.Enter)
				{
					e.Handled = true;
					// Perform a click on the button to save and restart
					buttonSaveRestart.PerformClick();
				}
			}
		}

		/// <summary>
		/// Save the score in the database and the launch a new game.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSaveRestart_Click(object sender, EventArgs e)
		{
			if (pseudoTextBox.TextLength > 3)
			{
				HangmanGame.DBRequests.InsertNewTodayDate();
				HangmanGame.DBRequests.InsertScoreToLeaderBoard(finalScore, nbOfTries, pseudoTextBox.Text, idWord, HangmanGame.DBRequests.GetLastDateOnServer().Item1);
				this.Close();
			}
		}

		/// <summary>
		/// Start a new game without saving the score in the database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRestart_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Close the application after the game is over
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
			Dispose();
		}
	}
}
