﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HangmanGame
{
	/// <summary>
	/// The word class to do some verifications on words.
	/// </summary>
	public static class Word
    {
		/// <summary>
		/// The number of vowels contains in the word.
		/// </summary>
		private static ushort nbVowels = 0;
		
		/// <summary>
		/// The number of consonants contains in the word.
		/// </summary>
		private static ushort nbConsonants = 0;
		
		/// <summary>
		/// The list of letters which are authorized for the player to try.
		/// </summary>
		private static List<char> Letters = new List<char>
        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-'};

		/// <summary>
		/// The number of vowels present in the word
		/// </summary>
		public static ushort NbVowels
		{
			get
			{
				return nbVowels;
			}
		}

		/// <summary>
		/// The number of consonants present in the word
		/// </summary>
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
			// Get the file path of the dictionary through the embedded resource.
			Stream dictionnaire = Assembly.GetExecutingAssembly().GetManifestResourceStream("HangmanGame.Resources.dictionary.txt");
            int nbOfLines = CountLinesInFile(dictionnaire);
			// Re set the Stream to reset the position, the readability and seekability in order to read it a 2nd time.
			dictionnaire = Assembly.GetExecutingAssembly().GetManifestResourceStream("HangmanGame.Resources.dictionary.txt");
			Random r = new Random();
			// Pick a random number between 0 and the number of lines count.
            long randomLineNumber = r.Next(0, nbOfLines);
			// Read the file while we haven't reach the random number
            StreamReader sr = new StreamReader(dictionnaire);
            string result = "";
            for (int i = 0; i != randomLineNumber; i++)
            {
				// Get the random word
                result = sr.ReadLine();
            }
            sr.Close();
            result = ReplaceAccent(result);
			// Finally return the word without its accents and in upper case.
			return result.ToUpper();
        }

		/// <summary>
		/// Replace all the accent character by its equivalent without it.
		/// </summary>
		/// <param name="result">The string to re-format</param>
		/// <returns></returns>
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

		/// <summary>
		/// Return the number of lines in the dictionary which represents the number of words there are. 
		/// </summary>
		/// <param name="dictionary">The dictionary to count</param>
		/// <returns></returns>
        private static int CountLinesInFile(Stream dictionary)
        {
            int count = 0;
            string line;
			// Read the file to its end
            StreamReader sr = new StreamReader(dictionary);
            while ((line = sr.ReadLine()) != null)
            {
				// Each line : +1 to line count.
                count++;
            }
            sr.Close();
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
        /// <param name="labelWordToFind">The container where to do the modifications.</param>
        public static void InsertTheLetterInsteadOfInterrogation(string characterToInsert, List<int> foundIndexes, Label labelWordToFind)
        {
            foreach (int i in foundIndexes)
            {
                labelWordToFind.Text = labelWordToFind.Text.Insert(i, characterToInsert);
                labelWordToFind.Text = labelWordToFind.Text.Remove(i + 1, 1);
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
						s += 0.06F;
						break;
					case 'B':
						s += 5.24F;
						break;
					case 'C':
						s += 2.86F;
						break;
					case 'D':
						s += 1.06F;
						break;
					case 'E':
						s += 0.12F;
						break;
					case 'F':
						s += 6.24F;
						break;
					case 'G':
						s += 5.14F;
						break;
					case 'H':
						s += 7.15F;
						break;
					case 'I':
						s += 0.24F;
						break;
					case 'J':
						s += 6.46F;
						break;
					case 'K':
						s += 9.42F;
						break;
					case 'L':
						s += 1.02F;
						break;
					case 'M':
						s += 2.15F;
						break;
					case 'N':
						s += 0.77F;
						break;
					case 'O':
						s += 1.04F;
						break;
					case 'P':
						s += 2.64F;
						break;
					case 'Q':
						s += 3.39F;
						break;
					case 'R':
						s += 0.89F;
						break;
					case 'S':
						s += 0.30F;
						break;
					case 'T':
						s += 0.32F;
						break;
					case 'U':
						s += 0.95F;
						break;
					case 'V':
						s += 3.242F;
						break;
					case 'W':
						s += 15.87F;
						break;
					case 'X':
						s += 7.90F;
						break;
					case 'Y':
						s += 8.41F;
						break;
					case 'Z':
						s += 7.26F;
						break;
				}
			}
			return s;
		}

		/// <summary>
		/// Set the two fields nbVowels and nbConsonants with the number of each which are present.
		/// </summary>
		/// <param name="word"></param>
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
