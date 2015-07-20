using System;
using MySql.Data.MySqlClient;

namespace HangmanGame
{
	public static class DBRequests
	{
		/// <summary>
		/// The MyMySqlConnection object to connect the app with the database
		/// </summary>
		private static MySqlConnection conn;

		/// <summary>
		/// The MySqlDataReader object is used to read the data when a select command is executed
		/// </summary>
		private static MySqlDataReader rdr;

		/// <summary>
		/// The MySqlCommand object the execute many requests to the database.
		/// </summary>
		private static MySqlCommand cmd;

		/// <summary>
		/// Open a new connection between the application and the database
		/// </summary>
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

		/// <summary>
		/// Close the connection between the application and the database
		/// </summary>
		private static void DBCloseConnection()
		{
			conn.Close();
			Console.WriteLine("Connection closed !");
		}

		/// <summary>
		/// Get a player id
		/// </summary>
		/// <param name="pseudo">The pseudo to look for an id</param>
		/// <returns></returns>
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

		/// <summary>
		/// Get the number of words in database
		/// </summary>
		/// <returns></returns>
		public static int GetWordsCount()
		{
			DBOpenConnection();
			string request = "SELECT COUNT(idWord) AS NumberOfWords FROM word";
			cmd = new MySqlCommand(request, conn);
			int res = Convert.ToInt32(cmd.ExecuteScalar());
			DBCloseConnection();
			return res;
		}

		/// <summary>
		/// Get a word by a random id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static string GetARandomWord(out int idWord)
		{
			Random r = new Random();
			DBOpenConnection();
			idWord = r.Next(1, HangmanGame.DBRequests.GetWordsCount() + 1);
			string request = @"
                SELECT        idWord, word, wordValue, wordLeveL
                FROM            word
                WHERE        (idWord = " + idWord + ");";
			cmd = new MySqlCommand(request, conn);
			rdr = cmd.ExecuteReader();
			rdr.Read();
			string res = rdr[1].ToString();
			rdr.Close();
			return res;
		}

		/// <summary>
		/// Get a word value by its id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static float GetWordValue(int id)
		{
			DBOpenConnection();
			string request = @"
                SELECT        idWord, word, wordValue, wordLeveL
                FROM            word
                WHERE        (idWord = " + id + ");";
			cmd = new MySqlCommand(request, conn);
			rdr = cmd.ExecuteReader();
			rdr.Read();
			float res = Convert.ToSingle(rdr[2].ToString());
			rdr.Close();
			return res;
		}

		/// <summary>
		/// Get a random word in a specific difficulty level
		/// </summary>
		/// <param name="wordLevel"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Insert a new player by its name, but check first if it's not already there.
		/// </summary>
		/// <param name="pseudo">The pseudo to add</param>
		public static void InsertNewPlayer(string pseudo)
		{
			DBOpenConnection();
			InsertNewTodayDate();
			if (pseudo != null & pseudo != "" && !PlayerExists(pseudo))
			{
				Tuple<int, string> lastDateOnServer = GetLastDateOnServer();
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

		/// <summary>
		/// Insert the today date in the database but check first if it's not already there.
		/// </summary>
		public static void InsertNewTodayDate()
		{
			Tuple<int, string> lastDateOnServer = GetLastDateOnServer();
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

		/// <summary>
		/// Insert a new record to the leaderboard
		/// </summary>
		/// <param name="score">The score added</param>
		/// <param name="remainingTries">The number of tries remaining</param>
		/// <param name="pseudo">The pseudo of the player</param>
		/// <param name="idWord">The id of the word played</param>
		/// <param name="idDate">The id of the today date</param>
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

		/// <summary>
		/// Get the last date present in the database
		/// </summary>
		/// <returns>A couple of value <idDate, stringDate></returns>
		public static Tuple<int, string> GetLastDateOnServer()
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

		/// <summary>
		/// Check if the player already exists in the database
		/// </summary>
		/// <param name="pseudo">The pseudo to look for</param>
		/// <returns></returns>
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
