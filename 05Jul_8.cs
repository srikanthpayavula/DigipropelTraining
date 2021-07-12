/*Write a c# program to generate a random number*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assmt_July
{
    class _05Jul_8
    {

        static void Main()
        {
            Console.WriteLine("Some Random Numbers that are generated are : ");
            for (int i = 1; i < 10; i++)
            {
                Randfunc();
            }
        }
        static Random r = new Random();
        static void Randfunc()
        {
            int n = r.Next();
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
/* output
 * Some Random Numbers that are generated are : 
1234567
8754352
9864930
8352048
1920472
2846104
7649207
4928756
9261746
 */
