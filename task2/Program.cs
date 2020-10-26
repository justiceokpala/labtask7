using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[5] { 10, 20, 30, 40, 50 };

            int[] b = new int[5] { 5, 4, 3, 2, 1 };

            int[] arr = new int[5];

            for (int i = 0, j = 0; i < a.Length; i++, j++)

            {

                arr[i] = a[i] * b[j];                             

            }

            for (int i = 0; i < arr.Length; i++)

            {

                Console.Write(arr[i] + " ");

            }

            Console.Read();

        }
    }
}
