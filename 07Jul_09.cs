using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace July
{
    class _07Jul_09
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                ArrayList words = new ArrayList();
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("E:\\practice\\Sample.txt");
                int count = 0;
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                   String[] string1 = line.ToLower().Split(new Char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine(line);
                    foreach (String s in string1)
                    {
                        words.Add(s);
                    }
                    count++;

                    //Read the next line
                    line = sr.ReadLine();
                }
                // Console.WriteLine("total count of lines  " + count);
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
