namespace Demo
{
    internal class Employee:ICloneable
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
    }
}
