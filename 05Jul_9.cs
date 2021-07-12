/*Make D:\csharp\example.dat file using BinaryWriter class, store current date and time and read that text using BinaryReader class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assmt_July
{


    class ConsoleApplication
    {
        const string fileName = "example.dat";


        static void Main()
        {
            WriteDefaultValues();
            DisplayValues();
        }

        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(Convert.ToString(DateTime.Now));
                // write the file directory and file location of example.dat file
                writer.Write(@"E:\practice\jul5_5\Assmt_July\Assmt_July\bin\Debug\example.dat");
            }
        }

        public static void DisplayValues()
        {
            string date;
            string tempDirectory;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    date = reader.ReadString();
                    tempDirectory = reader.ReadString();
                }

                Console.WriteLine("Current date and time: " + date);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.ReadLine();
            }
        }
    }
}

/*output
Current date and time  7/10/2021 3:48:01 PM
Temp directory is : E:\practice\jul5_5\Assmt_July\Assmt_July\bin\Debug


 */
