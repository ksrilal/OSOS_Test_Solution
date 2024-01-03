namespace OSOS_Test_Solution.Processors
{
    public interface IWordTransformProcessor
    {
        public string ReverseOrder(string word);
        public string ConvertVowelsToLowercase(string word);
        public string ConvertConsonantsToUppercase(string word);
        public string IgnoreNumbers(string word);
    }
}
