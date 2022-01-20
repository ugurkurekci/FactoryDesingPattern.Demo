using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Example2
{
    public class Scooter : IFactory
    {
        public void Color(string colorName)
        {
            Console.WriteLine("Color the Scooter : " + colorName + "color");
        }

        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "KM");
        }
    }
}
