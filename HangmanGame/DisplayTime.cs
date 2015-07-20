using System;

namespace HangmanGame
{
	/// <summary>
	/// A class to correctly display the elapsed in many ways
	/// </summary>
	public static class DisplayTime
	{
		/// <summary>
		/// Displays the elapsed time directly in the label
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
		
		/// <summary>
		/// Format the elapsed time.
		/// </summary>
		/// <param name="ts"></param>
		/// <returns>The elapsed time correctly formated</returns>
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
