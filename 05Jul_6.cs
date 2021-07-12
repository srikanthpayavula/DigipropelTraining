using System;

namespace _5Jul_6
{
    class Program
    {
        public void CheckLeapYear(int Year){
            if(Year%4==0 && Year%100!=0){
                Console.WriteLine("It is a Leap year " +Year);
            }
            else if(Year%100==0&&Year%400==0){
                 Console.WriteLine("It is a Leap year " +Year);
            }
            else{
                 Console.WriteLine("It is not a Leap year " +Year);
            }
        }
        static void Main(string[] args)
        {
            try{
            Program person=new Program();
            int Year;
            Console.WriteLine("Enter Year ");
            Year=Convert.ToInt32(Console.ReadLine());
            person.CheckLeapYear(Year);
            Console.ReadLine();}
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
