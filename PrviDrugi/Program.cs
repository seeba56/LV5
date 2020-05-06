using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviDrugi
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("Kinder surprise pack");
            Product EmptyEgg = new Product("Empty egg", 10.0, 1);
            Product FullEgg = new Product("Full egg", 10.0, 3);
            box.Add(EmptyEgg);
            box.Add(FullEgg);

            ShippingService price = new ShippingService(2);

            double weight = 0;
            weight += box.Weight;

            Console.WriteLine(box.Description());

            Console.WriteLine(price.ToString() + price.getPrice(weight) + "kn");
            
        }
    }
}
