using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{
    internal class MyType : Program, IMyType ,IComparable,ICloneable
    {
        public double Salary{ set; get;}

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void MyFun()
        {
            Console.WriteLine("Hello World :)");
        }
    }
}
