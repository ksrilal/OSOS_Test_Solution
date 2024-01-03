using OSOS_Test_Solution.Processors;

namespace OSOS_Test_Solution.Services
{
    public class WordTransformService : IWordTransformService
    {
        private readonly IWordTransformProcessor _wordTransformProcessor;

        public WordTransformService(IWordTransformProcessor wordTransformProcessor) 
        {
            _wordTransformProcessor = wordTransformProcessor;
        }

        public string Transform(string word)
        {
            //reverse order
            word = _wordTransformProcessor.ReverseOrder(word);

            //vowels to lowercase
            word = _wordTransformProcessor.ConvertVowelsToLowercase(word);

            //consonants to uppercase
            word = _wordTransformProcessor.ConvertConsonantsToUppercase(word);

            //ignore numbers
            word = _wordTransformProcessor.IgnoreNumbers(word);

            return word;
        }
    }
}
