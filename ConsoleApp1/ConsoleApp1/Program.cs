using System;

namespace SortAnArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int temp;
            int[] arrNumbers = new int[5];
            Console.Write("Read and print elements of an array: \n");
            Console.Write("\n-------------------------------------\n");
            Console.Write("Please Enter number of cases: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("element - {0}", i);
                arrNumbers[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("\nArraysOutput: \n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("The array index at {0} is:{1}  ", i, arrNumbers[i]);
            }
            Console.WriteLine("\nThe array numbers after sorting are: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arrNumbers[i] > arrNumbers[j])
                    {
                        temp = arrNumbers[i];
                        arrNumbers[i] = arrNumbers[j];
                        arrNumbers[j] = temp;
                    }
                }
            }
            foreach (int value in arrNumbers)
            {
                Console.Write(value + " ");
            }
            Console.ReadKey();



        }
    }
}
