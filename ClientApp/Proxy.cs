using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using WcfServices.Contracts;


namespace ClientApp
{

    public partial class MyContractClient : ClientBase<ICalculator>, ICalculator
    {
       public MyContractClient()
       {}

       public MyContractClient(string configurationName) : base(configurationName)
       {}

       public double Add(double x, double y)
       {
          return Channel.Add(x,y);
       }
    }

}
