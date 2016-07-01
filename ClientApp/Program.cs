using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContractClient proxy = new MyContractClient())
            {
                Console.WriteLine("Calling service");

                Console.WriteLine("add result"+proxy.Add(1.0,2.0));
                
                Console.ReadLine();
            }
        }
    }
}
