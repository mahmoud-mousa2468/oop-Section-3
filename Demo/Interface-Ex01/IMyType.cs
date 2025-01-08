using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{
    internal interface IMyType
    {
        // what can write inside the interface:
        //1-Signature of properties
        //2-Signature of methods [Name,Parameter,Return type]
        //3-Default Implmented Methods [Fully Implemented Methods]

        //1-Signature of properties
        double Salary { set; get; }

        //2-Signature of methods [Name,Parameter,Return type]
        void MyFun();

        //3-Default Implmented Methods [Fully Implemented Methods]
        void print()
        {
            Console.WriteLine("Default Implmented Methods [Fully Implemented Methods]");
        }
    }
}
