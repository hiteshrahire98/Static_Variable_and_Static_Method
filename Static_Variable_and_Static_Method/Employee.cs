using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable_and_Static_Method
{
    public class Employee
    {
        private int id;
        private string name;
        private double basicsalary;
        private static int count;

        public Employee(string name, double basicsalary)
        {
            count++;
          this.id = count;
          this.name = name;
          this.basicsalary = basicsalary;
        }

        public static string TotalCount()
        {
            return $"Total Count is:{count}";
        }

        public override string ToString()
        {
            return $"Id:{id} Name:{name} Salary:{basicsalary}";
        }
    }
}
