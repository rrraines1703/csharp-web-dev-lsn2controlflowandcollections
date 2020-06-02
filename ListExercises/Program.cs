using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Even(nums);

            List<string> sentences = new List<string> { "bob", "ricky", "britt", "aubrey", "natalie" };
            printFive(sentences);

            Console.WriteLine("How many characters is the word?");
            int searchInput = Convert.ToInt32(Console.ReadLine());
            userInput(sentences, searchInput);
        }
        static public void Even(List<int> nums)
        {
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }
        }

        static public void printFive(List<string> sentences)
        {
            foreach (string sentence in sentences)
            {
                if (sentence.ToString().Length == 5)
                    Console.WriteLine(sentence);
            }
        }

        static public void userInput(List<string> sentences, int len)
        {
            foreach (string sentence in sentences)
            {
                if (sentence.ToString().Length == len)
                    Console.WriteLine(sentence);
            }
        }
    }
}