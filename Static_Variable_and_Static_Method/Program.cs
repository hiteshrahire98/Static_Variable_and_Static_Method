using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable_and_Static_Method
{
    internal class Program
    {
        //static void Main(string[] args) // For Employee Class .....
        //{
        //    Employee e1 = new Employee("emp1",23000);
        //    Employee e2 = new Employee("emp2",24000);
        //    Employee e3 = new Employee("emp3",25000);
        //    Console.WriteLine(e1);
        //    Console.WriteLine(e2);
        //    Console.WriteLine(e3);
        //    Console.WriteLine(Employee.TotalCount());     
        //}

        //static void Main(string[] args)  // For NetPaid_Salary Class ....
        //{
        //    NetPaid_Salary e1 = new NetPaid_Salary("emp1", 23000);
        //    NetPaid_Salary e2 = new NetPaid_Salary("emp2", 24000);
        //    NetPaid_Salary e3 = new NetPaid_Salary("emp3", 25000);
        //    e1.CalculateSalary();
        //    e2.CalculateSalary();
        //    e3.CalculateSalary();

        //    Console.WriteLine(e1);
        //    Console.WriteLine(e2);
        //    Console.WriteLine(e3);
        //    Console.WriteLine(NetPaid_Salary.TotalCount());     
        //}

        static void Main(string[] args)  // For Student Class .....
        {
            Student s1 = new Student("Hitesh",70,80,90);
            Student s2 = new Student("Nitin",80,90,95);
            Student s3 = new Student("Sachin",85,90,95);
            s1.Calculate();
            s2.Calculate();
            s3.Calculate();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(Student.TotalCount());
        }
    }
}
