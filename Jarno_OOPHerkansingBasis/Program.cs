using Jarno_OOPHerkansingBasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarno_OOPHerkansingBasis
{
    class Program
    {
        static void Main(string[] args)
        {
            IceRocket ice = new IceRocket();
            ice.Eat();
            Console.WriteLine("------------------");
            Magnum magnum = new Magnum(MagnumIce.RomanticStrawberries);
            magnum.Eat();
            Console.WriteLine("------------------");
            Magnum magnum1 = new Magnum(MagnumIce.AlpineNuts);
            magnum1.Eat();
            Console.WriteLine("------------------");
            Cone cone = new Cone(Flavor.Banana);
            cone.Eat();
            Console.WriteLine("------------------");
            Cone cone1 = new Cone(Flavor.Strawberry);
            cone1.Eat();
        }
    }
}
