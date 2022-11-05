using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vinay_Simple_Interest
{
    public class Simple_Interest
    {
        public double PrincipleAmount { get; set; }
        public double Time { get; set; }
        public double RateOfInterest { get; set; }

        public void CalculateSimpleInterest()
        {
            double simpleInterest = (PrincipleAmount * Time * RateOfInterest) / 100;
            Console.WriteLine("Simple Interest for given Credentials  : "+ simpleInterest);

            double totalAmount=PrincipleAmount+simpleInterest;
            Console.WriteLine("Total amount to return : "+ totalAmount);
        }
    }
}
