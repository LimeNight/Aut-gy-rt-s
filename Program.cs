using Beadandó.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadandó
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Egy autó gyártása.*/
            Car car = new Car("Fiat", 1990, "Fehér", 270);
            Console.WriteLine(car.ToString());

            /* Tömeges gyártás. */
            Factory f = new Factory();
            f.Made();
            Console.WriteLine(f.ToString());

            Console.ReadKey();
        }
    }
}
