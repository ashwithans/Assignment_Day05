using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay5Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentGrades = new ArrayList();
            studentGrades.Add(85);
            studentGrades.Add(92);
            studentGrades.Add(78);
            studentGrades.Add(95);
            studentGrades.Add(88);


            //task2
            Console.WriteLine("Displaying the contents of studentGrades:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }

            int sum = 0;
            foreach (int grade in studentGrades)
            {
                sum += grade;
            }

            Console.WriteLine("The sum of all grades in studentGrades: " + sum);
            Console.WriteLine();
            

            //task3
            Console.WriteLine("Adding a new grade of 90 to the end of studentGrades.");
            studentGrades.Add(90); // Add a new grade of 90

            Console.WriteLine(" Displaying the updated contents of studentGrades:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine();



            //task4
            Console.WriteLine("Removing the grade of 78 from studentGrades.");
            studentGrades.Remove(78); // Remove the grade of 78

            Console.WriteLine("Displaying the updated contents of studentGrades:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine();


            //task5
            Console.WriteLine("Searching for the index of the grade 95 in studentGrades.");
            int index = studentGrades.IndexOf(95);

            if (index != -1)
            {
                Console.WriteLine("Found the grade 95 at index " + index);
                Console.WriteLine("Updating the grade at index " + index + " to 96.");
                studentGrades[index] = 96; // Update the grade at the found index to 96
            }
            else
            {
                Console.WriteLine("Grade 95 not found in studentGrades.");
            }

            Console.WriteLine("Displaying the updated contents of studentGrades:");
            foreach (int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            Console.ReadKey();
        }
    }
}
