using System.Collections;

namespace Demo
{
    class EmployeeComparerSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            // that's the logic of compare fun
            //if (X.Salary > Y.Salary) return 1;
            //else if (X.Salary < Y.Salary) return -1;
            //else return 0;

            // we use compareTo fun to reduce our codelines
            return X.Salary.CompareTo(Y.Salary);
        }
    }
    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee()
        {

        }
        // Another Way to Get Copy From An object
        // Copy Constructor 
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Age = employee.Age;
            Salary = employee.Salary;
        }
        // Clone Fun
        public object Clone()
        {
            return new Employee(this); // syntax sugar for the line below
            //return new Employee(){ Id = this.Id, Name = this.Name, Age = this.Age, Salary=this.Salary};
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj;
            // that's the logic of compare fun
            //if (this.Age > e.Age) return 1;
            //else if (this.Age < e.Age) return -1;
            //else return 0;


            // we use compareTo fun to reduce our codelines
            return this.Age.CompareTo(e.Age);
        }
    }
}
