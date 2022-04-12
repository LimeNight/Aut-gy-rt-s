using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadandó.Models
{
    internal class Car
    {
        private string brand;
        private int year;
        private double maxSpeed;
        private string color;

        public Car(string brand, int year, string color, int maxSpeed)
        {
            this.brand = brand;
            this.year = year;
            this.color = color;
            this.maxSpeed = maxSpeed;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double MaxSpeed
        {
            get { return maxSpeed; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public override string ToString()
        {
            return $"Az autó márkája {brand}, gyártási éve {year}, színe {color}, végsebessége {maxSpeed}";
        }
    }
}
