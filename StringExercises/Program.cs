using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");
            //3.7.2
            string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] words = sentence.Split("");
            Console.WriteLine(string.Join(",", words));

            string[] words2 = sentence.Split('.');
            Console.WriteLine(string.Join(",", words2));
        }
    }
}
