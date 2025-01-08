using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{
    internal class Airplane:IMoveable,IFlyable
    {
        int IMoveable.Speed { get; set; }
         int IFlyable.Speed { get; set; }

         void IMoveable.Backward()
        {
            Console.WriteLine("Car Imoveable BackWord");
        }

         void IMoveable.Forward()
        {
            Console.WriteLine("Car Imoveable Forward");
        }

         void IMoveable.Left()
        {
            Console.WriteLine("Car Imoveable Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Car Imoveable Right");

        }

         void IFlyable.Backward()
        {
            Console.WriteLine("Airplane IFlyable BackWord");
        }

         void IFlyable.Forward()
        {
            Console.WriteLine("Airplane IFlyable Forward");
        }

         void IFlyable.Left()
        {
            Console.WriteLine("Airplane IFlyable Left");
        }

         void IFlyable.Right()
        {
            Console.WriteLine("Airplane IFlyable Right");

        }
    }
}
