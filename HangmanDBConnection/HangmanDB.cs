using System;
using System.Data.CData.MySQL;

namespace HangmanDBConnection
{
    public static class HangmanDB
    {
        private static void DBOpenConnection(MySQLConnection conn)
        {
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("Connection opened...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to open...");
                Console.WriteLine(ex.ToString());
            }
        }
        private static void DBCloseConnection(MySQLConnection conn)
        {
            conn.Close();
            Console.WriteLine("Connection closed !");
        }
        private static int GetPlayerId(string pseudo, MySQLConnection conn)
        {
            DBOpenConnection(conn);
            if (PlayerExists(pseudo, conn))
            {
                string request = "SELECT idPlayer FROM player";
                MySQLCommand cmd = new MySQLCommand(request, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                return -1;
            }
        }
        private static int GetWordsCount(MySQLConnection conn)
        {
            DBOpenConnection(conn);
            string request = "SELECT COUNT(idWord) AS NumberOfWords FROM word";
            MySQLCommand cmd = new MySQLCommand(request, conn);
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            return res;
        }
        public static string GetWordById(int id, MySQLConnection conn)
        {
            DBOpenConnection(conn);
            string request = @"
                SELECT        idWord, word, wordValue, wordLeveL
                FROM            word
                WHERE        (idWord = " + id + ");";
            MySQLCommand cmd = new MySQLCommand(request, conn);
            MySQLDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            return rdr[1].ToString();
        }
        public static string GetWordByLevel(int wordLevel, MySQLConnection conn)
        {
            DBOpenConnection(conn);
            string request = @"
                SELECT        idWord, word, wordValue, wordLeveL
                FROM            word
                WHERE        (wordLeveL = " + wordLevel + ");";
            MySQLCommand cmd = new MySQLCommand(request, conn);
            MySQLDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            DBCloseConnection(conn);
            return rdr[1].ToString();
        }
        public static void InsertNewPlayer(string pseudo, MySQLConnection conn)
        {
            DBOpenConnection(conn);
            InsertNewTodayDate(conn);
            if (!PlayerExists(pseudo, conn))
            {
                Tuple<int, string> lastDateOnServer = LastDateOnServer(conn);
                int idTodayOnServer = lastDateOnServer.Item1;
                string todayOnServer = lastDateOnServer.Item2;
                string request = "INSERT INTO `player`(`pseudo`, `subscriptionDate`) VALUES ('" + pseudo + "', " + idTodayOnServer + ");";
                MySQLCommand cmd = new MySQLCommand(request, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine("Player {0} already exists !", pseudo);
            }
            DBCloseConnection(conn);
        }
        public static void InsertNewTodayDate(MySQLConnection conn)
        {
            Tuple<int, string> lastDateOnServer = LastDateOnServer(conn);
            int idTodayOnServer = lastDateOnServer.Item1;
            string todayOnServer = lastDateOnServer.Item2;
            string[] todayLocalArray = DateTime.Now.GetDateTimeFormats();
            string todayLocal = todayLocalArray[4].ToString();

            if (todayOnServer != todayLocalArray[4])
            {
                string request = @"INSERT INTO `date`(`date`) VALUES ('" + todayLocal + "');";
                MySQLCommand cmd = new MySQLCommand(request, conn);
                cmd.ExecuteNonQuery();
            }
        }
        public static void InsertScoreToLeaderBoard(float score, int remainingTries, string pseudo, int idWord, int idDate, MySQLConnection conn)
        {
            DBOpenConnection(conn);
            int playerId = GetPlayerId(pseudo, conn);

            string request = string.Format("INSERT INTO `leaderboard`(`scoreValue`, `remainingTries`, `idPlayer`, `idWordPlayed`, `idDateScored`) VALUES ({0},{1},{2},{3},{4})", score.ToString().Replace(',', '.'), remainingTries, playerId, idWord, idDate);
            MySQLCommand cmd = new MySQLCommand(request, conn);
            cmd.ExecuteNonQuery();
            DBCloseConnection(conn);
        }
        public static Tuple<int, string> LastDateOnServer(MySQLConnection conn)
        {
            string requestLastDate = @"SELECT MAX(idDate) AS LastDate, DATE_FORMAT(date, '%Y-%m-%d') FROM `date`";
            MySQLCommand cmdLastDate = new MySQLCommand(requestLastDate, conn);
            MySQLDataReader rdr = cmdLastDate.ExecuteReader();
            rdr.Read();
            if (rdr[0].ToString() != "" && rdr[1].ToString() != "")
            {
                return new Tuple<int, string>(Convert.ToInt32(rdr[0]), rdr[1].ToString());
            }
            else
            {
                return new Tuple<int, string>(-1, "Aucunes valeur reçues");
            }
        }
        private static bool PlayerExists(string pseudo, MySQLConnection conn)
        {
            string request = "SELECT pseudo FROM player WHERE (pseudo = '" + pseudo + "')";
            MySQLCommand cmd = new MySQLCommand(request, conn);
            MySQLDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (!rdr.HasRows /*&& rdr[0].ToString() != pseudo*/)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
