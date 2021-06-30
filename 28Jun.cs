using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.SumArray();
            Console.ReadLine();

            pr.ArrCnt();
            Console.ReadLine();

            pr.Reverse();
            Console.ReadLine();

            pr.SortAsc();
            Console.ReadLine();

            pr.MaxMin();
            Console.ReadLine();

            pr.Sum2Array();
            Console.ReadLine();
            
            /* miising numbers */
            int[] arr = new int[6];
                   int N = arr.Length;
        printMissingElements(arr, N);
            Console.ReadLine();

            pr.matrices();
            Console.ReadLine();

            pr.evenodd();
            Console.ReadLine();

            pr.FreqMiss();
            Console.ReadLine();

        }

        /*Write a program in C# Sharp to find the sum of all elements of the array*/
        public void SumArray()
        {
            int[] add = new int[3];
            Console.WriteLine("Enter array elements");
            //for giving input for array elements;
            for (int i = 0; i < add.Length; i++)
            {
                add[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            // for adding the array elements
            foreach (int item in add)
            {
                sum = sum + item;
            }
            Console.WriteLine("Adding the Array elements " + sum);
        }
        /*
         * Input
         15
          2
          3
         * 
         * output
         Adding the Array elements  20
         */

        /*Write a program in C# Sharp to count a total number of duplicate elements in an array.*/

        public void ArrCnt()
        {
            int[] Arrdup = new int[6];
            int i, j, count = 0;
            Console.WriteLine("Enter array elements");
            //for giving input for array elements;
            for (i = 0; i < Arrdup.Length; i++)
            {
                Arrdup[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for checking duplicate elements creating two loops;
            for (i = 0; i < Arrdup.Length; i++)
            {
                for (j = i + 1; j < Arrdup.Length; j++)
                {
                    if (Arrdup[i] == Arrdup[j])
                    {
                        count = count + 1;
                        //break;
                    }
                }
            }
            Console.WriteLine("count of duplicate elements :    " + count);
            Console.ReadLine();
        }

        /*
         * Input
         10
        20
        10
        30
        20
        40

        output
        count of duplicate elements : 4
         */

        /* Write a program in C# Sharp to read n number of values in an array and display it in reverse order.   */


        public void Reverse()
        {
            int[] ArrRev = new int[6];
            int i = 0;
            Console.WriteLine("enter array elements for reverse");
            for (i = 0; i < ArrRev.Length; i++)
            {
                ArrRev[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("reverse of array elements: ");
            for (i = ArrRev.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ArrRev[i]);
            }
            Console.ReadLine();
        }

        /*
         Input
        1
        2
        3
        4
        5

        output

        5
        4
        3
        2
        1
         */

        /* Write a program in C# Sharp to sort elements of array in ascending order. */

        public void SortAsc()
        {
            int[] ArrSort = new int[6];
            int i;
            Console.WriteLine("enter array elements for sort");
            for (i = 0; i < ArrSort.Length; i++)
            {
                ArrSort[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(ArrSort);
            Console.WriteLine("Sort of array elements in ascending order: ");

            for (i = 0; i < ArrSort.Length; i++)
            //  for ( i=ArrSort.Length-1; i>=0 ; i--)  // descending order//
            {
                Console.WriteLine(ArrSort[i] + " ");
            }
        }

        /*
         input 
        8
        4
        8
        2
        1

        output
        1
        2
        4
        8
        8
         */

        /* Write a program in C# to the add arrays in the following way.*/
        public void Sum2Array()
        {
            int[] Arr1 = new int[3];
            int[] Arr2 = new int[3];
            Console.WriteLine("Enter first array elements to add");
            //for giving input for array elements;
            for (int i = 0; i < Arr1.Length; i++)
            {
                Arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter second array elements to add");
            for (int j = 0; j < Arr2.Length; j++)
            {
                Arr2[j] = Convert.ToInt32(Console.ReadLine());
            }
            int sum1 = 0, sum2 = 0;

            //Array.Copy(Arr1,Arr2,3);
            // for adding the array elements
            for (int i = 0; i < Arr1.Length; i++)
            {
                sum1 = sum1 + Arr1[i];
            }

            // for adding the array elements
            for (int j = 0; j < Arr2.Length; j++)
            {
                sum2 = sum2 + Arr2[j];
            }
            int sum = sum1 + sum2;


            Console.WriteLine("Adding the Array elements " + sum);
        }

        /*
         * input 
         * first array
         1
        2
        3
        second array
        1
        2
        3
        output
        12
         */



        /* find maximum and minimum elements in array */

        public void MaxMin()
        {
            int[] ArrMax = new int[3];
            int max, min;

            int j;
            Console.WriteLine("Enter array elements");
            for (j = 0; j < ArrMax.Length; j++)
            {
                ArrMax[j] = Convert.ToInt32(Console.ReadLine());
            }

            max = ArrMax[0];
            min = ArrMax[0];
            // finding max element
            for (j = 1; j < 3; j++)
            {

                if (ArrMax[j] > max)
                {
                    max = ArrMax[j];
                }

                if (ArrMax[j] < min)
                {
                    min = ArrMax[j];
                }
            }

            Console.WriteLine("Maximum element in array  :  " + max);
            Console.WriteLine("Minimum element in array  :  " + min);
            // Console.ReadLine();
        }

        /*
         Input
        12
        24
        36
        output
        max 36
        min 12
         */

        /* find missing element in array */
        static void printMissingElements(int[] arr,
                                int N)
        {
            int[] ArrFreq = new int[6];
            int i, j;
            Console.WriteLine("Enter array elements");
            for (i = 0; i < ArrFreq.Length; i++)
            {
                ArrFreq[i] = Convert.ToInt32(Console.ReadLine());
            }
            int diff = ArrFreq[0] - 0;
            Console.WriteLine("missing number  ");
            for (i = 0; i < ArrFreq.Length; i++)
            {


                if (ArrFreq[i] - i != diff)
                {

                    // missing elements
                    while (diff < ArrFreq[i] - i)
                    {
                        Console.Write(i + diff + " ");
                        diff++;
                    }
                }
            }

        }
        /*
         input
1
3
5
6
9
11
missing number
2 4 7 8 10
             */

        /*find frequently occurence of elements in array*/
        public void FreqMiss()
        {
            int[] ArrFreq = new int[6];
            int i, j, n = 6;
            Console.WriteLine("Enter array elements");
            for (i = 0; i < ArrFreq.Length; i++)
            {
                ArrFreq[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool[] visited = new bool[6];
            for (i = 0; i < ArrFreq.Length; i++)
            {

                // Skip this element if already processed
                if (visited[i] == true)
                    continue;

                // Count frequency
                int count = 1;
                for (j = i + 1; j < ArrFreq.Length; j++)
                {
                    if (ArrFreq[i] == ArrFreq[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(ArrFreq[i] + "  " + count + " times");
            }

        }
        /*
         input
         10
         20
         10
         15
         20
         25
         output
         10 2 times
         15 1 times
         20 2 times
         25 1 times

             */

        /* accept two matrices check two values of matrices are equal are not*/

        public void matrices()
        {
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int i, j, r1, c1, r2, c2, flag = 1;

            Console.Write("\n\nAccept two matrices and check whether they are equal :\n ");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Input the number of rows in the 1st matrix : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the 1st matrix : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number of rows in the 2nd matrix : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the 2nd matrix : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The first matrix is :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            Console.Write("The second matrix is :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                    Console.Write("{0}  ", brr1[i, j]);
                Console.Write("\n");
            }

            /* Comparing two matrices for equality */

            if (r1 != r2 && c1 != c2)
            {
                Console.Write("The Matrices Cannot be compared :\n");
            }
            else
            {
                Console.Write("The Matrices can be compared : \n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        if (arr1[i, j] != brr1[i, j])
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if (flag == 1)
                    Console.Write("Two matrices are equal.\n\n");
                else
                    Console.Write("two matrices are not equal\n\n");
            }

        }
        /*
         input
         first matrix
         1 2
         3 4

        second matrix
        2 4
        5 6

        output
        two matrices are not equal

         */

        /* check odd and even integers in array*/
        public void evenodd()
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;
            Console.WriteLine("Enter the array elements:");
            for (i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
        }
        /*
         input 
         25
         24
         12
         35
         47
         output
         The Even elements are :
         24
         12
         The odd elements are :
         25
         35
         47
         */
    }
}



