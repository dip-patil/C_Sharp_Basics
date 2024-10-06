using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // A list of integers to use in the loop examples
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };


            Console.WriteLine("For Loop:");
            ForLoopExample(numbers);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("While Loop:");
            WhileLoopExample(numbers);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Do-While Loop:");
            DoWhileLoopExample(numbers);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Foreach Loop:");
            ForeachLoopExample(numbers);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\nAll loop examples completed successfully.");
            Console.ReadLine();
        }

        static void ForLoopExample(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Number at index {0}: {1}", i, numbers[i]);
            }
        }

        static void WhileLoopExample(List<int> numbers)
        {
            int i = 0;
            while (i < numbers.Count)
            {
                Console.WriteLine("Number at index {0}: {1}", i, numbers[i]);
                i++;
            }
        }

        static void DoWhileLoopExample(List<int> numbers)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Number at index {0}: {1}", i, numbers[i]);
                i++;
            } while (i < numbers.Count);
        }

        static void ForeachLoopExample(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine("Number: " + number);
            }
        }
    }
}

