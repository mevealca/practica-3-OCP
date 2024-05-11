

namespace OCP.Domain
{
    public class TaxCalculatorIndia: ICalculate
    {
        public double income { get; set; }
        public double deduction { get; set; }

        public double Calculate()
        {

            double totalAmount = (income - deduction) - 50;
            return totalAmount;
        }
    }
}
