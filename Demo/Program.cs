using Demo.Interface_Ex01;

namespace Demo
{
    internal class Program
    {
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
        }
    }
}
