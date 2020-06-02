/*using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, string> students = new Dictionary<double, string>();

            Console.WriteLine("Enter your students ID (or ENTER to finish):");
            string newStudent;
            double newID;
            // Get student IDs and names
            do
            {
                Console.WriteLine("Student ID: ");
                string input = Console.ReadLine();
                newID = double.Parse(input);

                if (!Equals(newID, 0))
                {
                    Console.WriteLine("Student Name: ");
                    input = Console.ReadLine();
                    newStudent = input;
                    students.Add(newID, newStudent);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newID, 0));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<double, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }


        }
    }
}*/

using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter student name (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student Name: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Student ID: ");
                    input = Console.ReadLine();
                    double newID = double.Parse(input);
                    students.Add(newStudent, newID);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<string, double> student in students)
            {
                Console.WriteLine(student.Value + " (" + student.Key + ")");
            }
        }
    }
}