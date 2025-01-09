using System.Text;
using Demo.Interface_Ex02;

namespace Demo
{
    internal class Program
    {
        static void Print10Number(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current} ");
                series.Next();
            }
            series.Reset();
        }
        static void Main(string[] args)
        {
            #region InterfaceEx01
            // Interfaces : Reference Type
            // Code Contract Between The Developer Who Write It And The Developer Who Use It

            //IMyType myType = new IMyType(); // Invalid 

            // Note : Can't Create Object From Any Interfaces

            //MyType myType = new MyType();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();

            //IMyType myType;
            //Ref-- > Can Refer To Object From Any Class Which Implemented The Interface 'IMyType'

            //myType = new MyType();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();
            //myType.print();
            #endregion

            #region InterfaceEx02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //SeriesByFour seriesByFour = new SeriesByFour();

            //Print10Number(seriesByFour);
            #endregion

            #region InterfaceEx03
            //Car car = new Car();
            //car.Speed = 120;
            //car.Forward();

            //Airplane airplane = new Airplane();

            //IMoveable moveable = airplane;
            //moveable.Forward();

            //IFlyable flyable = airplane;
            //flyable.Forward();
            #endregion

            #region Shallow Copy Vs Deep Copy
            #region Arr Of Value Type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02 = Arr01; //Shallow Copy
            ////Copy Identity
            //// {1,2,3} --> Has Two Ref Arr01,Arr02
            //// {4,5,6} --> UnReachable Object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            ////Identity (Address) + Object State [Data]

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02 = (int[])Arr01.Clone(); //Deep Copy
            ////Clone Method Will Copy The Object State Of The Caller
            //// Assign The New object To Arr02 , Will Generate New Identity

            //Console.WriteLine();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            ////Identity (Address) + Object State [Data]

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);
            #endregion

            #region Arr Of Ref Type

            //string[] Arr01 = { "Ahmed", "Ali", "mo" };
            //string[] Arr02 = { "medo", "marwan", "adam" };


            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02 = Arr01; //Shallow Copy
            //////Copy Identity
            ////// { "Ahmed", "Ali", "mo" } --> Has Two Ref Arr01,Arr02
            ////// { "medo", "marwan", "adam" } --> UnReachable Object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            ////Identity (Address) + Object State [Data]

            //Arr02[0] = "Eslam";

            //Console.WriteLine(Arr01[0]);


            //string[] Arr01 = { "Ahmed", "Ali", "mo" };
            //string[] Arr02 = { "medo", "marwan", "adam" };


            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02 = (string[])Arr01.Clone(); //Deep Copy
            ////Clone Method Will Copy The Object State Of The Caller
            //// Assign The New object To Arr02 , Will Generate New Identity

            //Console.WriteLine();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            ////Identity (Address) + Object State [Data]

            //Arr02[0] = "Eslam";

            //Console.WriteLine(Arr01[0]);

            #endregion

            #region Arr Of StringBuilder

            //StringBuilder[] Arr01 = new StringBuilder[]
            //{ new StringBuilder("Ahmed"),
            //  new StringBuilder("Ali"),
            //  new StringBuilder("Omar")};
            //StringBuilder[] Arr02 = new StringBuilder[]
            //{ new StringBuilder("medo"),
            //  new StringBuilder("eslam"),
            //  new StringBuilder("tamer")};


            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02 = Arr01; //Shallow Copy
            //////Copy Identity
            ////// { "Ahmed", "Ali", "mo" } --> Has Two Ref Arr01,Arr02
            ////// { "medo", "marwan", "adam" } --> UnReachable Object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            ////Identity (Address) + Object State [Data]

            //Arr02[0].Append("Ahmed Amin");

            //Console.WriteLine(Arr01[0]);


            //StringBuilder[] Arr01 = new StringBuilder[]
            //{ new StringBuilder("Ahmed"),
            //  new StringBuilder("Ali"),
            //  new StringBuilder("Omar")};
            //StringBuilder[] Arr02 = new StringBuilder[]
            //{ new StringBuilder("medo"),
            //  new StringBuilder("eslam"),
            //  new StringBuilder("tamer")};


            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr02 = (StringBuilder[])Arr01.Clone(); //Shallow Copy
            //////Copy Identity
            ////// { "Ahmed", "Ali", "mo" } --> Has Two Ref Arr01,Arr02
            ////// { "medo", "marwan", "adam" } --> UnReachable Object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            ////Identity (Address) + Object State [Data]

            //Arr02[0].Append("Ahmed Amin");

            //Console.WriteLine(Arr01[0]);

            #endregion
            #endregion
        }
    }
}
