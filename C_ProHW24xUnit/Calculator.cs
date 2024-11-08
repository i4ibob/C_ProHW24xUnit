using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProHW24xUnit
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return (double)a / b;
        }

        public double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new InvalidOperationException("Array cannot be empty");

            return numbers.Average();
        }

    }

}
