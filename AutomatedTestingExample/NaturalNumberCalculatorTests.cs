using Xunit;

namespace AutomatedTestingExample
{
    public class NaturalNumberCalculatorTests
    {
        [Fact]
        public void AddMethod_Numbers_Success()
        {
            var calculator = new NaturalNumberCalculator();
            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SubtractMethod_Numbers_Success()
        {
            var calculator = new NaturalNumberCalculator();
            var result = calculator.Subtract(1, 2);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void MutiplyMethod_Numbers_Success()
        {
            var calculator = new NaturalNumberCalculator();
            var result = calculator.Mulitiply(3, 2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void DivideMethod_Numbers_Success()
        {
            var calculator = new NaturalNumberCalculator();
            var result = calculator.Divide(4, 2);

            Assert.Equal(2, result);
        }
    }
}
