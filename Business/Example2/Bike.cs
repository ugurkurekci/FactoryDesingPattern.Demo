using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Example2
{
    internal class Bike : IFactory
    {
        public void Color(string colorName)
        {
            Console.WriteLine("Color the Bike : " + colorName + "color");
        }

        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}
