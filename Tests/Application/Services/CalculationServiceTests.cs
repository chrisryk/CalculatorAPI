using Application.Interfaces;
using Application.Services;

namespace Tests.Application.Services
{
    public class CalculationServiceTests
    {
        private ICalculationService _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new CalculationService();
        }

        [Test]
        public void Add_ShouldAddTwoNumbers()
        {
            var value1 = 234.5f;
            var value2 = 123.4f;
            var expectedResult = value1 + value2;

            var result = _sut.Add(value1, value2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Subtract_ShouldSubtractTwoNumbers()
        {
            var value1 = 234.5f;
            var value2 = 123.4f;
            var expectedResult = value1 - value2;

            var result = _sut.Subtract(value1, value2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Multiply_ShouldMultiplyTwoNumbers()
        {
            var value1 = 234.5f;
            var value2 = 123.4f;
            var expectedResult = value1 * value2;

            var result = _sut.Multiply(value1, value2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Divide_ShouldDivideTwoNumbers()
        {
            var value1 = 234.5f;
            var value2 = 123.4f;
            var expectedResult = value1 / value2;

            var result = _sut.Divide(value1, value2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Divide_ShouldThrowException_WhenDivisorIsZero()
        {
            var value1 = 234.5f;
            var value2 = 0;

            Assert.Throws<DivideByZeroException>(() => _sut.Divide(value1, value2));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(10)]
        public void Factorial_ShouldCalculateFactorial(int testValue)
        {
            var value = testValue;
            int expectedResult = 1;

            for (int i = 1; i <= value; i++)
            {
                expectedResult *= i;
            }

            var result = _sut.Factorial(value);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Factorial_ShouldThrowException_WhenValueIsNegative()
        {
            var value = -10;

            Assert.Throws<ArgumentException>(() => _sut.Factorial(value));
        }

        [Test]
        public void Factorial_ShouldThrowException_WhenValueExceedsTypeLimit()
        {
            var value = 50;

            Assert.Throws<OverflowException>(() => _sut.Factorial(value));
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(10, 89)]
        public void GetFibonacciAt_ShouldCalculateFibonacciSequenceAtIndex(int index, long expectedResult)
        {
            var result = _sut.GetFibonacciAt(index);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void GetFibonacciAt_ShouldThrowException_WhenIndexZeroOrNegative(int index)
        {
            Assert.Throws<ArgumentException>(() => _sut.GetFibonacciAt(index));
        }

        [Test]
        public void GetFibonacciAt_ShouldThrowException_WhenValueExceedsTypeLimit()
        {
            var index = 123;

            Assert.Throws<OverflowException>(() => _sut.GetFibonacciAt(index));
        }
    }
}