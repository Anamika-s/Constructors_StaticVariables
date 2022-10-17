using System;

namespace Constructors_StaticVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee.dept = "HR";
            //Console.WriteLine("Dept is " + Employee.dept);
            Console.WriteLine("Company Name is " + Employee.companyName);
            Employee.DisplayDept();
            // This will invoke cons > Def cons
            Employee employee = new Employee();
            employee.GetDetails();
            employee.DisplayDetails();

            // This will invoke cons > Para cons
            Employee emp2 = new Employee("Ajay");
            emp2.DisplayDetails();

            // This will invoke cons > Para cons
            Employee emp3 = new Employee(101, "Lalit");

            emp3.DisplayDetails();

            // This will invoke cons > Para cons
            Employee emp4 = new Employee(102, "Karan", 23000);
            emp4.DisplayDetails();

            // This will invoke cons > Copy cons
            Employee emp5 = new Employee(emp2);

        }
    }
}
