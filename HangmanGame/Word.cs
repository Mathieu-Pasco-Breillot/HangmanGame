using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public static class Word
    {
        private static List<char> Letters = new List<char>
        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-'};

        /// <summary>
        /// Check if the character just type is a valid one.
        /// </summary>
        /// <param name="word">The textbox which contains the word enter by the player</param>
        public static void HasValidCharacter(TextBox word)
        {
            // Shortcut to textbox length
            int tbLength = word.Text.Length;
            // Check if the textbox is not empty
            if (tbLength != 0)
            {
                // Check if the last caracter is one the allowed
                if (!Letters.Contains(word.Text.Last()))
                {
                    string enumAllow = "";
                    Letters.ForEach(delegate (char citem)
                    {
                        enumAllow += citem.ToString() + " | ";
                    });
                    word.Text = word.Text.Remove(tbLength - 1, 1);
                    word.Select(tbLength, 0);
                    MessageBox.Show(
                        "Le dernier caractère entré n'est pas valide. Il doit être un de ceux là : " + enumAllow,
                        "Erreur de caractère",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }
        public static void HasValidCharacter(MaskedTextBox word)
        {
            // Shortcut to textbox length
            int tbLength = word.Text.Length;
            // Check if the textbox is not empty
            if (tbLength != 0)
            {
                // Check if the last caracter is one the allowed
                if (!Letters.Contains(word.Text.Last()))
                {
                    string enumAllow = "";
                    Letters.ForEach(delegate (char citem)
                    {
                        enumAllow += citem.ToString() + " | ";
                    });
                    word.Text = word.Text.Remove(tbLength - 1, 1);
                    word.Select(tbLength, 0);
                    MessageBox.Show(
                        "Le dernier caractère entré n'est pas valide. Il doit être un de ceux là : " + enumAllow,
                        "Erreur de caractère",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }
        public static Dictionary<short, char> WhichCharactersAreWrong(string wordToFind, string WordToVerify)
        {
            Dictionary<short, char> badCharacters = new Dictionary<short, char>();
            for (short i = 0; i < wordToFind.Length; i++)
            {
                if (wordToFind[i] != WordToVerify[i])
                {
                    badCharacters.Add(i, WordToVerify[i]);
                }
            }
            return badCharacters;
        }

        public static string PickAWord()
        {
            string dictionnaire = "../../Resources/dictionnaire.txt";
            int nbOfLines = CountLinesInFile(dictionnaire);
            Random r = new Random();
            long randomLineNumber = r.Next(0, nbOfLines);
            StreamReader sr = new StreamReader(dictionnaire);
            string result = "";
            for (int i = 0; i != randomLineNumber; i++)
            {
                result = sr.ReadLine();
            }
            sr.Close();
            result = ReplaceAccent(result);
            return result.ToUpper();
        }

        private static string ReplaceAccent(string result)
        {
            if (result.Contains('é'))
            {
                result = result.Replace('é', 'e');
            }
            if (result.Contains('è'))
            {
                result = result.Replace('è', 'e');
            }
            if (result.Contains('ê'))
            {
                result = result.Replace('ê', 'e');
            }
            if (result.Contains('ë'))
            {
                result = result.Replace('ë', 'e');
            }
            if (result.Contains('à'))
            {
                result = result.Replace('à', 'a');
            }
            if (result.Contains('â'))
            {
                result = result.Replace('â', 'a');
            }
            if (result.Contains('ä'))
            {
                result = result.Replace('ä', 'a');
            }
            if (result.Contains('ï'))
            {
                result = result.Replace('ï', 'i');
            }
            if (result.Contains('î'))
            {
                result = result.Replace('î', 'i');
            }
            if (result.Contains('ö'))
            {
                result = result.Replace('ö', 'o');
            }
            if (result.Contains('ô'))
            {
                result = result.Replace('ô', 'o');
            }
            if (result.Contains('ù'))
            {
                result = result.Replace('ù', 'u');
            }
            if (result.Contains('û'))
            {
                result = result.Replace('û', 'u');
            }
            if (result.Contains('ü'))
            {
                result = result.Replace('ü', 'u');
            }
            if (result.Contains('ÿ'))
            {
                result = result.Replace('ÿ', 'y');
            }
            if (result.Contains('ç'))
            {
                result = result.Replace('ç', 'c');
            }
            return result;
        }

        private static int CountLinesInFile(string f)
        {
            int count = 0;
            string line;
            StreamReader r = new StreamReader(f);
            while ((line = r.ReadLine()) != null)
            {
                count++;
            }
            r.Close();
            return count;
        }
    }
}
