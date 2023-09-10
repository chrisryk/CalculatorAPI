using Application.Constants;
using Application.Interfaces;

namespace Application.Services
{
    public class CalculationService : ICalculationService
    {
        public float Add(float firstAddend, float secondAddend) => firstAddend + secondAddend;
        public float Subtract(float minuend, float subtrahend) => minuend - subtrahend;
        public float Multiply(float multiplier, float multiplicand) => multiplier * multiplicand;
        public float Divide(float dividend, float divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException(Messages.DivideByZero);
            }

            return dividend / divisor;
        }
        public int Factorial(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(Messages.NegativeValue);
            }

            return value > 1 ? value * Factorial(value - 1) : 1;
        }
        public int GetFibonacciAt(int value)
        {
            return value;
        }
    }
}
