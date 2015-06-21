﻿using System;
using System.Collections.Generic;
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
    }
}
