
namespace OCP.Domain
{
    public interface ICalculate
    {
        public double income { get; set; }
        public double deduction { get; set; }
        double Calculate();
    }
}
