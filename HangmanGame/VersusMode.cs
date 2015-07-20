using System;
using System.Windows.Forms;

namespace HangmanGame
{
	/// <summary>
	/// VersusMode Class
	/// </summary>
	public partial class VersusMode : Form
	{
		/// <summary>
		/// SoloMode form to finally launch the game but with the word chose by the other player.
		/// </summary>
		SoloMode formSm;

		/// <summary>
		/// The form constructor which take the previous ChooseGameMode form in parameter.
		/// </summary>
		/// <param name="cgm">The ChooseGameMode form to be close properly.</param>
		public VersusMode()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shut down the application correctly
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VersusMode_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Validate the maskedTextBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonValidateWordToFind_Click(object sender, EventArgs e)
		{
			if (maskedTextBoxWordToFind.Text != null && maskedTextBoxWordToFind.Text != "" && maskedTextBoxWordToFind.Text.Length >= 3)
			{
				if (maskedTextBox1.Text != null && maskedTextBox1.Text != "")
				{
					formSm = new SoloMode(maskedTextBoxWordToFind.Text, Convert.ToInt16(maskedTextBox1.Text));
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

		/// <summary>
		/// The event to detect if the player has pressed the Enter key.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void maskedTextBoxWordToFind_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				buttonValidateWordToFind.PerformClick();
			}
		}

		/// <summary>
		/// Verify if the last character entered is one of the allow.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void maskedTextBoxWordToFind_TextChanged(object sender, EventArgs e)
		{
			Word.HasValidCharacter(maskedTextBoxWordToFind);
		}
	}
}
