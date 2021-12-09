using NUnit.Framework;
using System.Text.RegularExpressions;


namespace Zen.UnitTests
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private StringCalculator _stringCalculator;

        [SetUp]
        public void SetUp()
        {
            _stringCalculator = new StringCalculator();
        }

        [Test]
        public void InputIsEmptyString_ReturnZero()
        {
            string input = "";
           int expectedResult = 0;

            var result = _stringCalculator.Add(input);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void InputIsOne_ReturnOne()
        {
            string input = "1";
           int expectedResult = 1;

            var result = _stringCalculator.Add(input);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void InputIsOneCommaTwo_ReturnThree()
        {
            string input = "1,2";
           int expectedResult = 3;

            var result = _stringCalculator.Add(input);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void InputIsOneCommaTwoCommaThree_ReturnSix()
        {
            string input = "1,2,3";
            
           int expectedResult = 6;

            var result = _stringCalculator.Add(input);

            Assert.AreEqual(expectedResult, result);
        }

         [Test]
        public void InputIsFiveCommaTwelveCommaEighteen_ReturnThirty()
        {
            string input = "5,12,18";
            
           int expectedResult = 35;

            var result = _stringCalculator.Add(input);

            Assert.AreEqual(expectedResult, result);
        }

         [Test]
        public void InputIsFiveCommaTwelvelineEighteen_ReturnThirtyfive()
        {
            string input = "5,12\n18";
            
           int expectedResult = 35;

            var result = _stringCalculator.Add(input);

            Assert.AreEqual(expectedResult, result);
        }

         [Test]
        public void InputIsDelimeterLine1SemicolonTwon_ReturnThree()
        {
            string input = "//;\n1;2";
            
           int expectedResult = 3;

            var result = _stringCalculator.Add(input);
            System.Diagnostics.Debug.WriteLine(result);
            Assert.AreEqual(expectedResult, result);
        }
    }

    public class StringCalculator{
        public int Add(string Numbers){
        
            if (string.IsNullOrEmpty(Numbers)){
                return 0;
            } 
          
           var splitNumbers = Numbers.Replace("\n", ",").Split(","); 
            //splitNumbers= ["1","2","3"]
            var sum = 0;
            for (int i = 0; i < splitNumbers.Length; i++){
                sum = int.Parse(splitNumbers[i]) + sum;
            }
            return sum;
        }
    }
}