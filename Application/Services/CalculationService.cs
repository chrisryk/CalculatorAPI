using Application.Constants;
using Application.Interfaces;

namespace Application.Services
{
    public class CalculationService : ICalculationService
    {
        /// <summary>
        /// Addition operation for two numbers.
        /// </summary>
        public float Add(float firstAddend, float secondAddend) => firstAddend + secondAddend;

        /// <summary>
        /// Subtraction operation for two numbers.
        /// </summary>
        public float Subtract(float minuend, float subtrahend) => minuend - subtrahend;

        /// <summary>
        /// Multiplication operation for two numbers.
        /// </summary>
        public float Multiply(float multiplier, float multiplicand) => multiplier * multiplicand;

        /// <summary>
        /// Division operation.
        /// </summary>
        /// <param name="divisor">Should not be 0.</param>
        /// <exception cref="DivideByZeroException"></exception>
        public float Divide(float dividend, float divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException(Messages.DivideByZero);
            }

            return dividend / divisor;
        }

        /// <summary>
        /// Calculates factorial for provided value.
        /// </summary>
        /// <param name="value">Should be grater or erquals 0.</param>
        /// <exception cref="ArgumentException"></exception>
        public long Factorial(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(Messages.NegativeValue);
            }

            return FactorialRecursive(value);
        }

        /// <summary>
        /// Helper for calculating factorial using recirsion.
        /// </summary>
        /// <param name="current">Default value should not be modified.</param>
        /// <param name="result">Default value should not be modified.</param>
        /// <returns></returns>
        /// <exception cref="OverflowException"></exception>
        private long FactorialRecursive(int value, int current = 1, long result = 1)
        {
            var calculatedValue = result * value;

            if (calculatedValue < 0)
            {
                throw new OverflowException(Messages.ValueOverflow);
            }
            else if (calculatedValue == 0) {
                return result;
            }

            return current == value ? calculatedValue : FactorialRecursive(value, current + 1, result * current);
        }

        /// <summary>
        /// Calculates Fibonacci sequence value at specific index, starting from a1=1, a2=2.
        /// </summary>
        /// <param name="index">Should be greater than 0.</param>
        /// <returns>Value at specific index.</returns>
        /// <exception cref="ArgumentException"></exception>
        public long GetFibonacciAt(int index)
        {
            if (index < 1)
            {
                throw new ArgumentException(Messages.FibonacciIncorrectIndex);
            }

            var penultimateValue = 0L;
            var lastValue = 1L;

            for (var i = 1; i < index; i++)
            {
                var oldPenultimateValue = penultimateValue;
                penultimateValue = lastValue;
                lastValue = oldPenultimateValue + lastValue;

                if (lastValue < 0)
                {
                    throw new OverflowException(Messages.ValueOverflow);
                }
            }

            return penultimateValue + lastValue;
        }
    }
}
