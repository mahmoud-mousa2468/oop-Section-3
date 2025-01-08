using Demo.Interface_Ex02;
using Demo.Interface_Ex03;

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
        }
    }
}
