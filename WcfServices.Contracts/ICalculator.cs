using System.ServiceModel;
namespace WcfServices.Contracts
{    
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x, double y);
    }
}
