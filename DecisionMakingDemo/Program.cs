using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DecisionMakingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grade Evaluation Program\n");

            
            Console.WriteLine("Enter your score (0 to 100):");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score == 100)
            {
                Console.WriteLine("You got a perfect score! Well done!");
            }

            if (score >= 50)
            {
                Console.WriteLine("Congratulations, you passed the exam.");
            }
            else
            {
                Console.WriteLine("Sorry, you failed the exam.");
            }

            if (score >= 90)
            {
                Console.WriteLine("Your grade is A.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Your grade is B.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Your grade is C.");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Your grade is D.");
            }
            else
            {
                Console.WriteLine("Your grade is F.");
            }

            if (score >= 90)
            {
                Console.WriteLine("You are an excellent student!");
                if (score == 100)
                {
                    Console.WriteLine("You achieved full marks!");
                }
            }
            else
            {
               
                if (score < 50)
                {
                    Console.WriteLine("Need to improve.");
                }
            }

            char grade;

            if (score >= 90) grade = 'A';
            else if (score >= 80) grade = 'B';
            else if (score >= 70) grade = 'C';
            else if (score >= 60) grade = 'D';
            else grade = 'F';

            

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Outstanding performance!");
                    break;
                case 'B':
                    Console.WriteLine("Good job, keep it up!");
                    break;
                case 'C':
                    Console.WriteLine("Fair performance, you can do better.");
                    break;
                case 'D':
                    Console.WriteLine("You passed, but strive for higher.");
                    break;
                case 'F':
                    Console.WriteLine("Fail - Work harder next time.");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }

            

            Console.WriteLine("\nProgram completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
