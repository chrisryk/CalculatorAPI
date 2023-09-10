namespace Application.Interfaces
{
    public interface ICalculationService
    {
        float Add(float firstAddend, float secondAddend);
        float Subtract(float minuend, float subtrahend);
        float Multiply(float multiplier, float multiplicand);
        float Divide(float dividend, float divisor);
        long Factorial(int value);
        long GetFibonacciAt(int index);
    }
}
