namespace OCP.Domain
{
    public class TaxCalculator 
    {

        public double Calculate(ICalculate calculate) {

            double totalAmount = calculate.Calculate();
            return totalAmount;
        
        }

}
}
