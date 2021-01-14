using Jarno_OOPHerkansingBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarno_OOPHerkansingBasis.Models
{
    public class IceRocket : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("I am eating an Ice Rocket");
            GetPrice();
        }

        public void GetPrice()
        {
            Console.WriteLine("The price for a Ice Rocket is 3.50$");
        }
    }
}
