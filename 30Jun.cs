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
             pr.SortStrAlpha();
            Console.ReadLine();

            pr.StrLength();
            Console.ReadLine();

             pr.StrWordCount();
            Console.ReadLine();

              pr.StringPosition();
            Console.ReadLine();

        }

        /*2.Write a program to accepst two names and sort them in alphabetical order*/
        public void SortStrAlpha()
        {
            List<string> names = new List<string>();
            names.Add("Zero");
            names.Add("Sita");

            names.Sort();
            foreach (string s in names)
                Console.WriteLine(s);
            Console.ReadLine();
        }

        /* Write a program in C# Sharp to find the length of a string*/
        public void StrLength()
        {
            Console.WriteLine("Enter the string value");
            string Name = Console.ReadLine();
            int NameLength = Name.Length;
            Console.WriteLine("Total number of words in the string is : " + NameLength);
        }

        /*5. Write a program in C# Sharp to count the total number of words in a string. */
        public void StrWordCount()
        {
            string Name;
            Console.WriteLine("enter string value");
            Name = Console.ReadLine();
            int wordCount = 0;

            for (int i = 0; i < Name.Length - 1; i++)
            {

                if (Name[i] == ' ' && Char.IsLetter(Name[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
            // count the words present in the string  
            wordCount++;

            //Displays the total number of words present in the given string  
            Console.WriteLine("Total number of words in the given string: " + wordCount);
        }

        /*6. Write a C# Sharp program to find the position of a specified word in a given string. */
        public void StringPosition()
        {
            string str1 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine("string value : " + str1);
            Console.WriteLine("Position of the word 'fox' in the said string: " + WordPosition(str1, "fox"));
            Console.WriteLine("Position of the word 'The' in the said string: " + WordPosition(str1, "The"));
            Console.WriteLine("Position of the word 'lazy' in the said string: " + WordPosition(str1, "lazy"));
        }
        public static int WordPosition(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }

    }

}
