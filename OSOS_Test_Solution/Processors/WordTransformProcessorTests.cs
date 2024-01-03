using Xunit;

namespace OSOS_Test_Solution.Processors
{
    public class WordTransformProcessorTests
    {
        private readonly WordTransformProcessor _wordTransformProcessor;

        public WordTransformProcessorTests()
        {
            _wordTransformProcessor = new WordTransformProcessor();
        }

        [Theory]
        [InlineData("Hello", "olleH")]
        [InlineData("Apple123", "321elppA")]
        [InlineData("", "")]
        [InlineData("123", "321")]
        [InlineData(null, "")]
        public void ReverseOrder_ShouldReturnExpected(string input, string expectedOutput)
        {
            // Act
            var result = _wordTransformProcessor.ReverseOrder(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("Hello", "Hello")]
        [InlineData("Apple123", "apple123")]
        [InlineData("", "")]
        [InlineData("123", "123")]
        [InlineData(null, "")]
        public void ConvertVowelsToLowercase_ShouldReturnExpected(string input, string expectedOutput)
        {
            // Act
            var result = _wordTransformProcessor.ConvertVowelsToLowercase(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("Hello", "HeLLo")]
        [InlineData("Apple123", "APPLe123")]
        [InlineData("", "")]
        [InlineData("123", "123")]
        [InlineData(null, "")]
        public void ConvertConsonantsToUppercase_ShouldReturnExpected(string input, string expectedOutput)
        {
            // Act
            var result = _wordTransformProcessor.ConvertConsonantsToUppercase(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("Hello", "Hello")]
        [InlineData("Apple123", "Apple")]
        [InlineData("", "")]
        [InlineData("123", "")]
        [InlineData(null, "")]
        public void IgnoreNumbers_ShouldReturnExpected(string input, string expectedOutput)
        {
            // Act
            var result = _wordTransformProcessor.IgnoreNumbers(input);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

    }
}
