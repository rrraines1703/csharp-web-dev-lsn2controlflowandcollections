using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            //3.7.1
            int[] arr = { 1, 1, 2, 3, 5, 8 };
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
