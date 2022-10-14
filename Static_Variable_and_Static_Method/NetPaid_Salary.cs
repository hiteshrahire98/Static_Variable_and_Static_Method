using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable_and_Static_Method
{
    public class NetPaid_Salary
    {
        private int id;
        private string name;
        private int basicsalary;
        private double hra, da, pf, gross, net;
        private static int count;

        public NetPaid_Salary(string name, int basicsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsalary = basicsalary;
        }

        public void CalculateSalary()
        {
            hra = basicsalary * 0.4;
            da = basicsalary * 0.2;
            gross = basicsalary + hra + da;
            pf = basicsalary * 0.12;
            net = gross - pf;
        }
        public static string TotalCount()
        {
            return $"Total Count is:{count}";
        }
        public override string ToString()
        {
            return $"Id:{id} Name:{name} Salary:{basicsalary} Gross Salary:{gross} Net Salaey:{net}";
        }
    }
}
