namespace SimpleCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 3;
            int result = calculator.Add(a, b);
            Assert.Equal(8,result);
        }
        [Fact]
        public void Divide_ShouldThrowException_WhenDivideByZero()
        {
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 0;
            Assert.Throws<ArgumentException>(()=> calculator.Divide(a,b));
        }
        [Theory]
        [InlineData(4,3)]
        [InlineData(6,2)]
        public void Multiply_ShouldReturn12(int a,int b)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(a,b);
            Assert.Equal(12,result);
        }
        
    }
}