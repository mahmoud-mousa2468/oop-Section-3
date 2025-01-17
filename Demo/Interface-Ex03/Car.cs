using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{
    internal class Car : IMoveable
    {
        public int Speed { get ; set ; }

        public void Backward()
        {
            Console.WriteLine("Car Imoveable BackWord");
        }

        public void Forward()
        {
            Console.WriteLine("Car Imoveable Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car Imoveable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car Imoveable Right");

        }
    }
}
