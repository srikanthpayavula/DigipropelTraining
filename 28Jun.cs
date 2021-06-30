using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            //pr.SumArray();
            //Console.ReadLine();

            //pr.ArrCnt();
            //Console.ReadLine();

            //pr.Reverse();
            //Console.ReadLine();

            pr.SortAsc();
            Console.ReadLine();

            //pr.MaxMin();
            //Console.ReadLine();

            //pr.Sum2Array();
            //Console.ReadLine();
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
           for(i=0;i<Arrdup.Length;i++)
           {
            Arrdup[i]=Convert.ToInt32(Console.ReadLine());
                     }
            //for checking duplicate elements creating two loops;
           for (i=0;i<Arrdup.Length;i++){
            for(j=i+1;j<Arrdup.Length;j++){
            if(Arrdup[i]==Arrdup[j]){      
                        count=count+1;
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
            int i=0;
            Console.WriteLine("enter array elements for reverse");
            for( i = 0; i < ArrRev.Length; i++)
            {
                ArrRev[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("reverse of array elements: ");
            for (i = ArrRev.Length-1; i>=0; i--)
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
               Console.WriteLine( ArrSort[i] + " ");
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
            int sum1 = 0,sum2=0;

            //Array.Copy(Arr1,Arr2,3);
            // for adding the array elements
            for (int i = 0; i < Arr1.Length; i++)
            {
                sum1 = sum1 + Arr1[i];
            }

            // for adding the array elements
            for (int j = 0; j < Arr2.Length; j++)
            {
                sum2=sum2+Arr2[j];
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
        }
    }
