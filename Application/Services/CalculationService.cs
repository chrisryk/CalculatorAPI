using Application.Interfaces;

namespace Application.Services
{
    public class CalculationService : ICalcualtionService
    {
        public int Add(int firstOperand, int secondOperand) => firstOperand + secondOperand;
    }
}
