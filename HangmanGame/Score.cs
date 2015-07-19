using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
	public partial class Score : Form
	{
		private float finalScore;
		private int nbOfTries;
		private int idWord;
		public Score(float finalScore, int nbOfTries, int idWord, ref Stopwatch timer)
		{
			this.finalScore = finalScore;
			this.nbOfTries = nbOfTries;
			this.idWord = idWord;
			InitializeComponent();
			this.Text = "Félicitations !";
			this.labelFinal.Text = "! ! ! Vous avez trouvé le mot ! ! !" + "\nVotre score : " + finalScore + " points !" + "\nVotre temps : " + DisplayTime.displayElapsedTime(timer.Elapsed);
		}
		public Score(string wordToFind)
		{
			InitializeComponent();
			this.Text = "C'est dommage...";
			this.labelFinal.Text = "Vous n'avez pas trouvé le mot... \nLe mot à trouver était : " + wordToFind;
			this.buttonSaveRestart.Enabled = false;
		}

		private void pseudoTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (pseudoTextBox.Text != "" && pseudoTextBox.TextLength > 3)
			{
				if (e.KeyChar == (char)Keys.Enter)
				{
					e.Handled = true;
					buttonSaveRestart.PerformClick();
				}
			}
		}

		private void buttonSaveRestart_Click(object sender, EventArgs e)
		{
			if (pseudoTextBox.TextLength > 3)
			{
				HangmanGame.DBRequests.InsertNewTodayDate();
				HangmanGame.DBRequests.InsertScoreToLeaderBoard(finalScore, nbOfTries, pseudoTextBox.Text, idWord, HangmanGame.DBRequests.LastDateOnServer().Item1);
				this.Close(); 
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
			Dispose();
		}

		private void buttonRestart_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
