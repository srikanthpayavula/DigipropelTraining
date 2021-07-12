using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assmt_July
{
    class _5Jul_10
    {
        static void Main()
        {

            try
            {
                string fileName = @"E:\practice\test.txt";
           
                using (FileStream fs = File.Create(fileName, 1024, FileOptions.WriteThrough))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    fs.Write(author, 0, author.Length);
                }
                Console.WriteLine( fileName);
                Console.WriteLine("Hello File Handling ");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
