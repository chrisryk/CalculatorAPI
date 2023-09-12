namespace Application.Interfaces
{
    public interface ICalculationService
    {
        decimal Add(decimal firstAddend, decimal secondAddend);
        decimal Subtract(decimal minuend, decimal subtrahend);
        decimal Multiply(decimal multiplier, decimal multiplicand);
        decimal Divide(decimal dividend, decimal divisor);
        long Factorial(long value);
        long GetFibonacciAt(long index);
    }
}
