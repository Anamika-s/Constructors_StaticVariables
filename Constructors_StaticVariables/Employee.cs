using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_StaticVariables
{
    class Employee
    {
        int id;
        string name;
        static string dept;
        public const string companyName="CTS";
        int salary;
        static int count;
        // Def Cons
          public Employee() {}

        // Para Cons
        public Employee(string name)
        {
            //Employee employee = new Employee();
            this.name = name;
            Console.WriteLine("Enter ID");
            id = Int16.Parse(Console.ReadLine());
           
            //Console.WriteLine("Enter dept");
            //dept = Console.ReadLine();
            //Console.WriteLine("Enter companyName");
            //companyName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Int32.Parse(Console.ReadLine());
            count++;

        }


        // Para Cons
        public Employee(int id, string name)
        {
            this.name = name;
            this.id = id;
            //Console.WriteLine("Enter dept");
            //dept = Console.ReadLine();
            //Console.WriteLine("Enter companyName");
            //companyName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Int32.Parse(Console.ReadLine());
            count++;

        }

        // Para Cons
        public Employee(int id, string name  , int salary)
        {
            this.name = name;
            this.id = id;
            //dept = "HR";
            //this.companyName = companyName;
            this.salary = salary;
            count++;

        }
       
        // Copy Cons
        public Employee (Employee employee)
        {
            Console.WriteLine("Enter ID");
            id = Int16.Parse(Console.ReadLine());
            this.name = employee.name;
            //dept = "HR";
            //this.companyName = employee.companyName;
            this.salary = employee.salary;
        }
        // Static Cons
        // are only 1 in a class
        // They are wothout any access specifier
        // It is paramterless
        static Employee()
        {
            dept = "HR";

        }
        public void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter dept");
            //dept = Console.ReadLine();
            //Console.WriteLine("Enter companyName");
            //companyName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Int32.Parse(Console.ReadLine());
            count++;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Id is {id}\nName is {name}\nSalary is {salary}");
            Console.WriteLine($"No. of Employees are {count}");
        }
        public static void DisplayDept()
        {
            //dept = "HR";
            Console.WriteLine("Dept is " + dept) ;
        }
    }
}
