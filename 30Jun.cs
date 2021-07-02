using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            
             pr.EnumProgram();
           Console.ReadLine();

            pr.StrUpper();
            Console.Read();
          
            pr.StringAltUppercase();
            Console.ReadLine();

            pr.StrAltLen();
            Console.Read();

            pr.StringCompare();
            Console.Read();

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
            
        }
        /*
        output
        Sita
        Zero
        */

        /* Write a program in C# Sharp to find the length of a string*/
        public void StrLength()
        {
            Console.WriteLine("Enter the string value");
            string Name = Console.ReadLine();
            int NameLength = Name.Length;
            Console.WriteLine("Total number of words in the string is : " + NameLength);
        }
        /* Input    
         digipropel.com
         output
         13
         */

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
        /*Input  
        This is first program
        output
        4
        */

        /*6. Write a C# Sharp program to find the position of a specified word in a given string. */
        public void StringPosition()
        {
            string str1 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine("string value : " + str1);
            Console.WriteLine("Position of the word 'fox' in the said string: " + WordPosition(str1, "fox"));
            Console.WriteLine("Position of the word 'the' in the said string: " + WordPosition(str1, "the"));
            Console.WriteLine("Position of the word 'lazy' in the said string: " + WordPosition(str1, "lazy"));
        }
        public static int WordPosition(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }
        /*Input
        The quick brown fox jumps over the lazy dog.
        output
        fox   4
        the   7
        lazy  8
        */
        
        /*program to convert first charcter of string in sentence to uppercase*/
        public void StrUpper()
        {
            String str = "The quick brown Fox jumps over the little lazy Dog";
            Console.WriteLine("Original String value:  " + str);
            Console.WriteLine("After Converting String:");
            Console.WriteLine(StrConvert(str));
            Console.ReadLine();
        }        
        
        static String StrConvert(String str)
        {

            char[] ch = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {

                // If first character of a word is found

                if (i == 0 && ch[i] != ' ' ||
                    ch[i] != ' ' && ch[i - 1] == ' ')
                {

                    // If it is in lower-case
                    if (ch[i] >= 'a' && ch[i] <= 'z')
                    {

                        // Convert into Upper-case
                        ch[i] = (char)(ch[i] - 'a' + 'A');
                    }
                }

                // If apart from first character
                // Any one is in Upper-case
                else if (ch[i] >= 'A' && ch[i] <= 'Z')

                    // Convert into Lower-Case
                    ch[i] = (char)(ch[i] + 'a' - 'A');
            }

            // Convert the char array to
            // equivalent String
            String st = new String(ch);

            return st;

        }


        // function to reverse all the words which has even length
        public void StrAltLen()
        {
            string str1 = "C# Exercises";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("\nReverse all the words of the said string which have even length.:\n" + test(str1));
            str1 = "C# is used to develop web apps , desktop apps , mobile apps , games and much more.";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("\nReverse all the words of the said string which have even length.:\n" + test(str1));

        }
        public static string test(string text)
        {
            return string.Join(" ", text.Split(' ').Select(str => str.Length % 2 != 0 ? str : new String(str.Reverse().ToArray())));
        }

        /*write a program for enum */
        public void EnumProgram()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
        }

        /* 3.Write a C# Sharp program to display alphabet pattern like B with an asterisk*/
        public void Pattern()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'B' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    
/* program to convert alternate charcter in sentence to upper case*/

        public void StringAltUppercase()
        {

            string str = "C# is used to develop web apps, desktop apps, mobile apps, games and much more.";
            Console.WriteLine("Original string:   " + str);
            char[] ch = str.ToCharArray();

            StringBuilder strbld = new StringBuilder();

            for (int i = 0; i < ch.Length; i++)
            {
                //converting even index as uppercase
                if (i % 2 == 0)
                {
                    ch[i] = char.ToUpper(ch[i]);

                }
                else
                { ////converting odd index as lowercase
                    ch[i] = char.ToLower(ch[i]);
                }
                strbld.Append(ch[i].ToString());

            }

            Console.WriteLine(strbld.ToString());

        }

        /* Write a C# Sharp program to compares four sets of words by using each member of the string comparison enumeration. */

        public void StringCompare()
        {
            String[] cultureNames = { "en-AU", "sv-SE" };
            String[] strs1 = { "case",  "encyclopedia",
                            "encyclopedia", "Archeology" };
            String[] strs2 = { "Case", "encyclopedia",
                            "encyclopedia" , "ARCHEOLOGY" };
            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++)
                {
                    foreach (var comparison in comparisons)
                        Console.WriteLine("   {0} = {1} ({2}): {3}", strs1[ctr],
                                          strs2[ctr], comparison,
                                          String.Equals(strs1[ctr], strs2[ctr], comparison));

                    Console.WriteLine();
                }
                Console.WriteLine();

            }
        }

    }
   }
