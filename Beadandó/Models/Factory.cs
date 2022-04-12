using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadandó.Models
{
    internal class Factory
    {
        private readonly List<Car> carlist;
        private readonly Reader reader;

        /*Car típusú lista és beolvasó */
        public Factory()
        {
            carlist = new List<Car>();
            reader = new Reader();
        }
        /*Autó gyártása*/
        public void Made()
        {
            reader.Beolv(@"Car.txt");
            List<string[]> rendeles =  reader.GetList;
            foreach (string[] x in rendeles)
            {
                string brand = x[0];
                int year = int.Parse(x[1]);
                string color = x[2];
                int maxSpeed = int.Parse(x[3]);
                carlist.Add(new Car(brand, year, color, maxSpeed ));
            }
        }
        /*Car osztály ToString hívása*/
        public override string ToString()
        {
            string a = "";
            foreach (Car car in carlist)
            {
                a += car.ToString();
                a += "\n";
            }
            return a;
        }
    }
}
