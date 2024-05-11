
namespace OCP.Domain
{
    public class TaxCalculatorUSA: ICalculate
    {
        public double income { get; set; }
        public double deduction { get; set; }
        public double Calculate()
        {
            double totalAmount = (income - deduction) - 150;
            return totalAmount;
        }
    }
}
