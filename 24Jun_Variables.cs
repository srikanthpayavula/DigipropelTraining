using System;

namespace onedrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
    int a=10,b=20;
      short c=30;
      double k=a+b+c; 
      Console.WriteLine("Result : " + k);
         a=Convert.ToInt32(Console.ReadLine());
           k=a+b+c;
           //  Console.WriteLine("after adding input of a={0}",a);
             Console.WriteLine("Result after adding input of a : " + k);
        }
    }
}
