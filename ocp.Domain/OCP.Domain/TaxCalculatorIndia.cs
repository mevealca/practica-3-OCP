
namespace OCP.Domain
{
    public class TaxCalculatorUK : ICalculate
    {
        public double income { get; set; }
        public double deduction { get; set; }
        public double Calculate()
        {
            double totalAmount = (income - deduction)-100;
            return totalAmount;
        }
    }
}
