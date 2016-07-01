using WcfServices.Contracts;
namespace WcfServices.Services
{
    public class CalculatorService:ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y+100;
        }
    }
}
