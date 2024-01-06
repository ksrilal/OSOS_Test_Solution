using System;
using System.Text.RegularExpressions;

namespace OSOS_Test_Solution.Processors
{
    public class WordTransformProcessor : IWordTransformProcessor
    {
        private readonly HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        public string ConvertConsonantsToUppercase(string word)
        {
            word = HandleNull(word);

            char[] charArray = word.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (IsConsonant(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            return new string(charArray);
        }

        public string ConvertVowelsToLowercase(string word)
        {
            word = HandleNull(word);

            char[] charArray = word.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (IsVowels(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
            }

            return new string(charArray);
        }

        public string IgnoreNumbers(string word)
        {
            word = HandleNull(word);
            return Regex.Replace(word, @"\d", "");
        }

        public string ReverseOrder(string word)
        {
            word = HandleNull(word);
            return new string(word.Reverse().ToArray());
        }

        private string HandleNull(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }
            return word;
        }

        private bool IsConsonant(char c)
        {
            return char.IsLetter(c) && !vowels.Contains(char.ToLower(c));
        }

        private bool IsVowels(char c)
        {
            return char.IsLetter(c) && vowels.Contains(char.ToLower(c));
        }

    }
}
