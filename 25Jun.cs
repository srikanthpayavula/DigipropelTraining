using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assmt
{
    class Program
    {
        static void Main(string[] args)
        {


           Program pr = new Program();
            pr.Multi();
            Console.ReadLine();
            pr.AddMulDiv();
            Console.ReadLine();
              pr.Average();
              Console.ReadLine();
             pr.sum();
             Console.ReadLine();
             pr.strword();
             Console.ReadLine();
            pr.check();
            Console.ReadLine();
        }


        public void Multi()
        {
            int a = 1, b = 1, c = 1;
            Console.WriteLine("Enter Values for Multiplication ");
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ", c);
            c = Convert.ToInt32(Console.ReadLine());
            int k = a * b * c;
            Console.WriteLine("Result after multiply " + k);
        }

        public void AddMulDiv()
        {
            int a = 1, b = 1;
            Console.WriteLine("Enter Values for addition ");
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b = Convert.ToInt32(Console.ReadLine());

            int add = a + b;
            Console.WriteLine("Result after adding two values " + add);

            Console.WriteLine("Enter Values for subtraction ");
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b = Convert.ToInt32(Console.ReadLine());

            int sub = a - b;
            Console.WriteLine("Result after subtracting two values " + sub);

            Console.WriteLine("Enter Values for Multiplication ");
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b = Convert.ToInt32(Console.ReadLine());

            int mul = a * b;
            Console.WriteLine("Result after multiply of two values " + mul);

            Console.WriteLine("Enter Values for division ");
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b = Convert.ToInt32(Console.ReadLine());

            int div = a / b;
            Console.WriteLine("Result after dividing two values " + div);
        }

        public void Average()
        {
            int a = 1, b = 1, c = 1, d = 1;
            Console.WriteLine("Enter Values for Average ");
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ", c);
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter d: ", d);
            d = Convert.ToInt32(Console.ReadLine());
            int avg = (a + b + c + d) / 4;
            Console.WriteLine("Result after Average of four values  " + avg);

        }

      
        public void sum()
        {
            int a = 1, b = 1;
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                int k = (a + b) * (a + b) *( a + b) ;
                Console.WriteLine("Result after Triple of sum  " + k);
            }
        
        }

        public void strword()
        {
            string a = "";
            Console.WriteLine("Enter string value");
            a = Console.ReadLine();
            Console.WriteLine("Enter word to check in string");
            string b = "";
            b = Console.ReadLine();

            Console.WriteLine("Result after checking word  " + a.Contains(b));
        }
    
 bool check(){
         int a = 1, b = 1;
            Console.WriteLine("Enter Values for Checking Positive sign or Negative sign ");
            Console.WriteLine("Enter a: ", a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ", b);
            b= Convert.ToInt32(Console.ReadLine());

            if (a > 0 && b < 0)
            {
                Console.WriteLine("true");
                return true;

            }
            else 
            {
                Console.WriteLine("false");
               return false;
            }
           // return true;
        
           

    }          
}
    
}