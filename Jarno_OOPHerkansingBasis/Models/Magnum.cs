using Jarno_OOPHerkansingBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarno_OOPHerkansingBasis.Models
{
    public enum MagnumIce
    {
        MilkChocolate,
        WhiteChocolate,
        BlackChocolate,
        AlpineNuts,
        RomanticStrawberries
    }
    public class Magnum : IEatable
    {
        private MagnumIce _magnumIce { get; set; }

        public Magnum(MagnumIce magnumIce)
        {
            this._magnumIce = magnumIce;
        }

        public void Eat()
        {
            Console.WriteLine($"I am eating a Magnum with {_magnumIce}");
            GetPrice();
        }

        public void GetPrice()
        {
            switch (_magnumIce)
            {
                case MagnumIce.MilkChocolate:
                    PriceList.MilkChocolate();
                    break;
                case MagnumIce.WhiteChocolate:
                    PriceList.WhiteChocolate();
                    break;
                case MagnumIce.BlackChocolate:
                    PriceList.BlackChocolate();
                    break;
                case MagnumIce.AlpineNuts:
                    PriceList.Alpinenuts();
                    break;
                case MagnumIce.RomanticStrawberries:
                    PriceList.RomanticStrawberries();
                    break;
                default:
                    break;
            }
        }
    }
}
