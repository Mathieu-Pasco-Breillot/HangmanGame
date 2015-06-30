using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HangmanGame
{
	/// <summary>
	/// The word class to do some verifications on words.
	/// </summary>
	public static class Word
    {
		private static ushort nbVowels = 0, nbConsonants = 0;
		private static List<char> Letters = new List<char>
        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-'};

		public static ushort NbVowels
		{
			get
			{
				return nbVowels;
			}
		}

		public static ushort NbConsonants
		{
			get
			{
				return nbConsonants;
			}
		}



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

        /// <summary>
        /// Check if the character just type is a valid one.
        /// </summary>
        /// <param name="word">The maskedTextbox which contains the word enter by the player</param>
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

        /// <summary>
        /// Verify each character one by one if they are the same at the same position, if not it's added to the dictionary.
        /// </summary>
        /// <param name="wordToFind">The word to find</param>
        /// <param name="wordToVerify">The word enter by the player</param>
        /// <returns>A dictionary which contains the bad characters entered.</returns>
        public static Dictionary<short, char> WhichCharactersAreWrong(string wordToFind, string wordToVerify)
        {
            int lentghToGoMax;
            if (wordToFind.Length < wordToVerify.Length)
            {
                lentghToGoMax = wordToFind.Length;
            }
            else
            {
                lentghToGoMax = wordToVerify.Length;
            }
            Dictionary<short, char> badCharacters = new Dictionary<short, char>();
            for (short i = 0; i < lentghToGoMax; i++)
            {
                if (wordToFind[i] != wordToVerify[i])
                {
                    badCharacters.Add(i, wordToVerify[i]);
                }
            }
            return badCharacters;
        }

        /// <summary>
        /// Get a random word from the file which contains more than 336 500 words.
        /// </summary>
        /// <returns>The word picked in a random way</returns>
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

        /// <summary>
        /// Get all the indexes of the character for the given word.
        /// </summary>
        /// <param name="characterToVerify">The character to look for.</param>
        /// <param name="wordToFind">The word in which it's check.</param>
        /// <returns></returns>
        public static List<int> FoundIndexes(string characterToVerify, string wordToFind)
        {
            var foundIndexes = new List<int>();
            for (int i = wordToFind.IndexOf(characterToVerify); i >= 0; i = wordToFind.IndexOf(characterToVerify, i + 1))
            {
                // For loop end when i=-1 (character not found)
                foundIndexes.Add(i);
            }

            return foundIndexes;
        }

        /// <summary>
        /// Replace the existing interrogation point by the letter to replace.
        /// </summary>
        /// <param name="characterToInsert">The character to be inserted instead of the existing "?".</param>
        /// <param name="foundIndexes">The indexes where to do the replacements.</param>
        /// <param name="richTextBoxWordToFind">The container where to do the modifications.</param>
        public static void InsertTheLetterInsteadOfInterrogation(string characterToInsert, List<int> foundIndexes, RichTextBox richTextBoxWordToFind)
        {
            foreach (int i in foundIndexes)
            {
                richTextBoxWordToFind.Text = richTextBoxWordToFind.Text.Insert(i, characterToInsert);
                richTextBoxWordToFind.Text = richTextBoxWordToFind.Text.Remove(i + 1, 1);
            }
        }

        /// <summary>
        /// Check if the character is in the word.
        /// </summary>
        /// <param name="c">The character entered by the player</param>
        /// <param name="word">The word to check in.</param>
        /// <returns>True if it's present.</returns>
        public static bool IsContained(string c, string word)
        {
            bool resultat = false;
            if (c.Length != 0)
            {
                foreach (char ch in word)
                {
                    if (c == ch.ToString())
                    {
                        resultat = true;
                    }
                }
            }
            return resultat;
        }

		/// <summary>
		/// Do the sum of the letters value for the word.
		/// </summary>
		/// <param name="word"></param>
		/// <returns>A float value which represents the difficulty of the word.</returns>
		public static float SumLettersByPresence(string word)
		{
			float s = 0;
			foreach (char c in word)
			{
				switch (c)
				{
					case 'A':
						s += 9.42F;
						break;
					case 'B':
						s += 1.02F;
						break;
					case 'C':
						s += 2.64F;
						break;
					case 'D':
						s += 3.39F;
						break;
					case 'E':
						s += 15.87F;
						break;
					case 'F':
						s += 0.95F;
						break;
					case 'G':
						s += 1.04F;
						break;
					case 'H':
						s += 0.77F;
						break;
					case 'I':
						s += 8.41F;
						break;
					case 'J':
						s += 0.89F;
						break;
					case 'K':
						s += 0.06F;
						break;
					case 'L':
						s += 5.24F;
						break;
					case 'M':
						s += 3.242F;
						break;
					case 'N':
						s += 7.15F;
						break;
					case 'O':
						s += 5.14F;
						break;
					case 'P':
						s += 2.86F;
						break;
					case 'Q':
						s += 1.06F;
						break;
					case 'R':
						s += 6.46F;
						break;
					case 'S':
						s += 7.90F;
						break;
					case 'T':
						s += 7.26F;
						break;
					case 'U':
						s += 6.24F;
						break;
					case 'V':
						s += 2.15F;
						break;
					case 'W':
						s += 0.12F;
						break;
					case 'X':
						s += 0.30F;
						break;
					case 'Y':
						s += 0.24F;
						break;
					case 'Z':
						s += 0.32F;
						break;
				}
			}
			return s;
		}

		public static void CountNbVowelsConsonants(string word)
		{
			foreach (char c in word)
			{
				if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y')
				{
					nbVowels++;
				}
				else
				{
					nbConsonants++;
				}
			}
		}
	}
}
