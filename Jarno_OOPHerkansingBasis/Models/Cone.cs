using Jarno_OOPHerkansingBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarno_OOPHerkansingBasis.Models
{
    public enum Flavor
    {
        Strawberry,
        Banana,
        Chocolate,
        Vanilla,
        Mokka
    }
    public class Cone:IEatable
    {
        private Flavor _flavor { get; set; }

        public Cone(Flavor flavor)
        {
            this._flavor = flavor;
        }
       
        public void Eat()
        {
            Console.WriteLine($"I am eating a cone with {_flavor}");
            GetPrice();
        }

        public void GetPrice()
        {
            switch (_flavor)
            {
                case Flavor.Strawberry:
                    PriceList.Strawberry();
                    break;
                case Flavor.Banana:
                    PriceList.Banana();
                    break;
                case Flavor.Chocolate:
                    PriceList.Chocolate();
                    break;
                case Flavor.Vanilla:
                    PriceList.Vanilla();
                    break;
                case Flavor.Mokka:
                    PriceList.Mokka();
                    break;
                default:
                    break;
            }
        }
    }
}
