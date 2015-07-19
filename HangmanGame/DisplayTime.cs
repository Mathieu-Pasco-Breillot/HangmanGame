using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
	public static class DisplayTime
	{
		/// <summary>
		/// Displays the elapsed time in the GUI
		/// Starts when the action on the start button has been triggered
		/// </summary>
		public static void displayElapsedTime(TimeSpan ts, System.Windows.Forms.Label label)
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
		public static string displayElapsedTime(TimeSpan ts)
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
	}
}
