using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July
{
    class Program
    {
        
            class Student
        {
            private int rollno;
            private string name;
            private string course;
            private int feepaid;

            public Student(int rollno, string name, string course)
            {
                this.rollno = rollno;
                this.name = name;
                this.course = course;
            }

            public void Payment(int amount)
            {
                feepaid += amount;
            }

            public void Print()
            {
                Console.WriteLine(rollno);
                Console.WriteLine(name);
                Console.WriteLine(course);
                Console.WriteLine(feepaid);
            }

            public int DueAmount
            {

                get
                {
                    return TotalFee - feepaid;
                }
            }

            public int TotalFee
            {
                get
                {
                    return course == "c#" ? 2000 : 3000;
                }
            }
        }

        class UseStudent
        {

            //public static void Main()
            //{

            //    Student s = new Student(1, "ABC", "c#");
            //    s.Payment(1000);
            //    s.Print();
            //    Console.WriteLine(s.DueAmount);
            //    Console.ReadLine();
            //}
        }
    }
}
/*
output
1
ABC
c#
1000
1000
*/
