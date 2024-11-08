using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace C_ProHW24xUnit
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            var result = _calculator.Divide(6, 3);
            Assert.Equal(2.0, result, 1); // проверяем точность до одного знака после запятой
        }

        [Fact]
        public void Divide_ShouldThrowException_WhenDividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }

        [Fact]
        public void CalculateAverage_ShouldReturnCorrectResult_ForPositiveAndNegativeNumbers()
        {
            var result = _calculator.CalculateAverage(new[] { 1, -2, 3, -4 });
            Assert.Equal(-0.5, result, 1); // проверяем точность до одного знака после запятой
        }

        [Fact]
        public void CalculateAverage_ShouldThrowException_ForEmptyArray()
        {
            Assert.Throws<InvalidOperationException>(() => _calculator.CalculateAverage(new int[0]));
        }
    }
}
