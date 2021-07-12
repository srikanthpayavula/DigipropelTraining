using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Assmt_July
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            String line;
//            try
//            {
//                //Pass the file path and file name to the StreamReader constructor
//                StreamReader sr = new StreamReader("E:\\practice\\Sample.txt");
//                int count = 0;
//                //Read the first line of text
//                line = sr.ReadLine();
//                //Continue to read until you reach end of file
//                while (line != null)
//                {
//                    //write the lie to console window
//                    Console.WriteLine(line);
//                    count++;

//                    //Read the next line
//                    line = sr.ReadLine();
//                }
//                Console.WriteLine("total count of lines  " + count);
//                //close the file
//                sr.Close();
//                Console.ReadLine();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Exception: " + e.Message);
//            }
//            finally
//            {
//                Console.WriteLine("Executing finally block.");
//            }
//        }
//    }
//}
/*output
 Hello World!
How are you
This program
is to read file and
count the 
number of files in line
total count of lines 6
     */
