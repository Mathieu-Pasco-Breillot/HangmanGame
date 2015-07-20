using System;
using System.Windows.Forms;

namespace HangmanGame
{
	/// <summary>
	/// ChooseGameMode Class
	/// </summary>
	public partial class ChooseGameMode : Form
    {
        /// <summary>
        /// The form constructor which take the previous form in parameter.
        /// </summary>
        public ChooseGameMode()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Launch the solo mode form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void buttonSoloMode_Click(object sender, EventArgs e)
        {
            SoloMode sm = new SoloMode();
            Hide();
            sm.ShowDialog();
        }

		/// <summary>
		/// Launch the versus mode form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void buttonVersusMode_Click(object sender, EventArgs e)
        {
            VersusMode sm = new VersusMode();
            Hide();
            sm.ShowDialog();
        }
    }
}
