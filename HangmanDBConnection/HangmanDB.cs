using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using MySql.Data.MySqlClient;

namespace HangmanGame
{
	public static class DBRequests
	{
		// Global variables
		private static MySqlConnection conn;
		private static MySqlDataReader rdr;
		private static MySqlCommand cmd;

		private static void DBOpenConnection()
		{
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				// Création de la chaîne de connexion
				string connectionString = "SERVER=127.0.0.1; DATABASE=hangmangamedatabase; UID=vs2015; PASSWORD=vs2015";
				conn = new MySqlConnection(connectionString);
				conn.Open();
				Console.WriteLine("Connection opened !");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failed to open...");
				Console.WriteLine(ex.ToString());
			}
		}
		private static void DBCloseConnection()
		{
			conn.Close();
			Console.WriteLine("Connection closed !");
		}
		private static int GetPlayerId(string pseudo)
		{
			DBOpenConnection();
			if (PlayerExists(pseudo))
			{
				string request = "SELECT idPlayer FROM player";
				MySqlCommand cmd = new MySqlCommand(request, conn);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
			else
			{
				return -1;
			}
		}
		public static int GetWordsCount()
		{
			DBOpenConnection();
			string request = "SELECT COUNT(idWord) AS NumberOfWords FROM word";
			cmd = new MySqlCommand(request, conn);
			int res = Convert.ToInt32(cmd.ExecuteScalar());
			DBCloseConnection();
			return res;
		}
		public static string GetWordById(int id)
		{
			DBOpenConnection();
			string request = @"
                SELECT        idWord, word, wordValue, wordLeveL
                FROM            word
                WHERE        (idWord = " + id + ");";
			cmd = new MySqlCommand(request, conn);
			rdr = cmd.ExecuteReader();
			rdr.Read();
			string res = rdr[1].ToString();
			rdr.Close();
			return res;
		}
		public static string GetWordByLevel(int wordLevel)
		{
			DBOpenConnection();
			string res;
			string request = @"
                SELECT        idWord, word, wordValue, wordLeveL
                FROM            word
                WHERE        (wordLeveL = " + wordLevel + ");";
			cmd = new MySqlCommand(request, conn);
			rdr = cmd.ExecuteReader();
			rdr.Read();
			DBCloseConnection();
			res = rdr[1].ToString();
			rdr.Close();
			return res;
		}
		public static void InsertNewPlayer(string pseudo)
		{
			DBOpenConnection();
			InsertNewTodayDate();
			if (pseudo != null & pseudo != "" && !PlayerExists(pseudo))
			{
				Tuple<int, string> lastDateOnServer = LastDateOnServer();
				int idTodayOnServer = lastDateOnServer.Item1;
				string todayOnServer = lastDateOnServer.Item2;
				string request = "INSERT INTO `player`(`pseudo`, `subscriptionDate`) VALUES ('" + pseudo + "', " + idTodayOnServer + ");";
				cmd = new MySqlCommand(request, conn);
				cmd.ExecuteNonQuery();
			}
			else
			{
				Console.WriteLine("Player {0} already exists !", pseudo);
			}
			DBCloseConnection();
		}
		public static void InsertNewTodayDate()
		{
			Tuple<int, string> lastDateOnServer = LastDateOnServer();
			int idTodayOnServer = lastDateOnServer.Item1;
			string todayOnServer = lastDateOnServer.Item2;
			string[] todayLocalArray = DateTime.Now.GetDateTimeFormats();
			string todayLocal = todayLocalArray[4].ToString();

			if (todayOnServer != todayLocalArray[4])
			{
				string request = @"INSERT INTO `date`(`date`) VALUES ('" + todayLocal + "');";
				cmd = new MySqlCommand(request, conn);
				cmd.ExecuteNonQuery();
			}
		}
		public static void InsertScoreToLeaderBoard(float score, int remainingTries, string pseudo, int idWord, int idDate)
		{
			DBOpenConnection();
			InsertNewPlayer(pseudo);
			int playerId = GetPlayerId(pseudo);
			string request = string.Format("INSERT INTO `leaderboard`(`scoreValue`, `remainingTries`, `idPlayer`, `idWordPlayed`, `idDateScored`) VALUES ({0},{1},{2},{3},{4})", score.ToString().Replace(',', '.'), remainingTries, playerId, idWord, idDate);
			cmd = new MySqlCommand(request, conn);
			cmd.ExecuteNonQuery();
			DBCloseConnection();
		}
		public static Tuple<int, string> LastDateOnServer()
		{
			string requestLastDate = @"SELECT idDate, DATE_FORMAT(date, '%Y-%m-%d') FROM `date` WHERE idDate = (SELECT max(idDate) FROM date);";
			Tuple<int, string> res;
			MySqlCommand cmdLastDate = new MySqlCommand(requestLastDate, conn);
			rdr = cmdLastDate.ExecuteReader();
			rdr.Read();
			if (rdr[0].ToString() != "" && rdr[1].ToString() != "")
			{
				res = new Tuple<int, string>(Convert.ToInt32(rdr[0]), rdr[1].ToString());
			}
			else
			{
				res = new Tuple<int, string>(-1, "Aucunes valeur reçues");
			}
			rdr.Close();
			return res;
		}
		private static bool PlayerExists(string pseudo)
		{
			bool res;
			string request = "SELECT pseudo FROM player WHERE (pseudo = '" + pseudo + "')";
			MySqlCommand cmd = new MySqlCommand(request, conn);
			rdr = cmd.ExecuteReader();
			rdr.Read();
			if (!rdr.HasRows)
			{
				res = false;
			}
			else
			{
				res = true;
			}
			rdr.Close();
			return res;
		}
	}
}
