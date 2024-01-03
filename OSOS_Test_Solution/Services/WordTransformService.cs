using OSOS_Test_Solution.Processors;

namespace OSOS_Test_Solution.Services
{
    public class WordTransformService : IWordTransformService
    {
        public string Transform(string word)
        {
            IWordTransformProcessor wordTransformProcessor = new WordTransformProcessor();

            //reverse order
            word = wordTransformProcessor.ReverseOrder(word);

            //vowels to lowercase
            word = wordTransformProcessor.ConvertVowelsToLowercase(word);

            //consonants to uppercase
            word = wordTransformProcessor.ConvertConsonantsToUppercase(word);

            //ignore numbers
            word = wordTransformProcessor.IgnoreNumbers(word);

            return word;
        }
    }
}
