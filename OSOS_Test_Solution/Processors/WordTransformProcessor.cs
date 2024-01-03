using System.Text.RegularExpressions;

namespace OSOS_Test_Solution.Processors
{
    public class WordTransformProcessor : IWordTransformProcessor
    {
        public string ConvertConsonantsToUppercase(string word)
        {
            if (string.IsNullOrEmpty(word))
            { 
                return string.Empty;
            }

            bool IsConsonant(char c)
            {
                return !IsVowel(c) && char.IsLetter(c);
            }

            bool IsVowel(char c)
            {
                return "aeiou".Contains(char.ToLower(c));
            }

            char[] charArray = word.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                char lowercaseChar = char.ToLower(charArray[i]);

                if (IsConsonant(lowercaseChar))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            return new string(charArray);
        }

        public string ConvertVowelsToLowercase(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }

            char[] charArray = word.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                char lowercaseChar = char.ToLower(charArray[i]);
                switch (char.ToLower(charArray[i]))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        charArray[i] = lowercaseChar;
                        break;
                    default:
                        break;
                }
            }

            return new string(charArray);
        }

        public string IgnoreNumbers(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }
            return Regex.Replace(word, @"\d", "");
        }

        public string ReverseOrder(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }
            return new string(word.Reverse().ToArray());
        }
    }
}
