using System;
/* write a program to compare two dates*/
namespace _5Jul_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year1,day1,month1,year2,day2,month2;
            Console.WriteLine("enter first date : ");
            Console.WriteLine("Year : ");
            year1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month : ");
            month1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date : ");
            day1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second date : ");
            Console.WriteLine("Year : ");
            year2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month : ");
            month2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date : ");
            day2=Convert.ToInt32(Console.ReadLine());
            
            DateTime date1=new DateTime(year1,month1,day1);
            DateTime date2=new DateTime(year2,month2,day2);
            if(date1==date2){
                Console.WriteLine("Date of {0} is equal {1}",date1,date2);
            }
            if(date1<date2){
                Console.WriteLine("Date of {0} is before {1}",date1,date2);
            }   
            if(date1>date2){
                Console.WriteLine("Date of {0} is after {1}",date1,date2);
            } 
            Console.Read();                                
        }
    }
}
