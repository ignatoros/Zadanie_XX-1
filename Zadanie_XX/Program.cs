using System;

namespace Zadanie_XX
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] array = new int[] { 5, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            
        }
        static void pervoe(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] * 2);
            }

        }
        static void vtoroe(int[] array)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] - a);
            }
        }
        static void tretie(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item / array[0]);
            }
        }
        static void chetvertoe(int[] array, int index)
        {
            index = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(array[5]));

        }
        static void FIVE(int [] array)
        {
           int  a = int.Parse(Console.ReadLine());
           int  b = int.Parse(Console.ReadLine());
            Console.WriteLine((array[a] + array[b]) / 2); 
        } 


    }
}
