using Xunit;

namespace CodeCoverage.UnitTests
{
    public class UnitTest1
    {
        private readonly Calculator _calculator;
        public UnitTest1()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_WhenNumberAndNumber2AreGiven_ReturnsSum()
        {
            //Arrange
            var oneNumber = 1;
            var twoNumber = 2;

            //Act
            var sum = _calculator.Add(oneNumber, twoNumber);

            //Assert
            Assert.Equal(oneNumber + twoNumber, sum);
        }

        [Fact]
        public void Subtract_WhenNumberAndNumber2AreGiven_ReturnsDifference()
        {
            //Arrange
            var oneNumber = 2;
            var twoNumber = 1;

            //Act
            var sum = _calculator.Subtract(oneNumber, twoNumber);

            //Assert
            Assert.Equal(oneNumber - twoNumber, sum);
        }
    }
}