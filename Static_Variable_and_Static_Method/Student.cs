using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable_and_Static_Method
{
    public class Student
    {
        private int rollno;
        private string name;
        private int sub1,sub2, sub3,total;
        private double percentage;
        private static int count;

        public Student(string name, int sub1, int sub2, int sub3)
        {
            count++;
            this.rollno = count;
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;

        }
        public void Calculate()
        { 
          total=sub1 + sub2 + sub3;
            percentage=total/3;
        }
        public static string TotalCount()
        { 
           return $"Total Count is:{count}";

        }

        public override string ToString()
        {
            return $"RollNo:{rollno}   Name:{name}   Total:{total}   Percentage:{percentage}";
        }

    }
}
