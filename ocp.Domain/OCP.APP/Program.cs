using OCP.Domain;

Console.WriteLine("Ingresar el valor del pais al que desea calcular los impuestos 'India = 1/ USA=2/ UK=3'");
int country= int.Parse(Console.ReadLine());

ICalculate calculate;


switch (country)
{
    case (int)PaisesEnum.INDIA:
        calculate = new TaxCalculatorIndia();
        break;

    case (int)PaisesEnum.USA:
        calculate = new TaxCalculatorUSA();
        break;

    case (int)PaisesEnum.UK:
        calculate = new TaxCalculatorUK();
        break;

    default:
        Console.WriteLine($"El Pais {country} no esta registrado");
		return;
}

Console.WriteLine("Suministrar ingresos");
double income = double.Parse(Console.ReadLine());

Console.WriteLine("Suministrar disminución");
double discount = double.Parse(Console.ReadLine());

calculate.income = income;
calculate.deduction = discount;
double taxAmount = calculate.Calculate();

Console.WriteLine($"El impuesto es: {taxAmount}");
