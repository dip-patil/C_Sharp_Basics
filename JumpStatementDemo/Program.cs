using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JumpStatementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Break Statement");
            BreakExample();

            Console.WriteLine("\nDemonstrating Continue Statement");
            ContinueExample();

            Console.WriteLine("\nDemonstrating Goto Statement");
            GotoExample();

            Console.WriteLine("\nDemonstrating Return Statement");
            ReturnExample();

            //Console.WriteLine("\nDemonstrating Throw Statement");
            //try
            //{
            //    ThrowExample();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Caught Exception: " + ex.Message);
            //}

            Console.WriteLine("\nProgram ended.");
            Console.ReadLine();
        }


        static void BreakExample()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Breaking the loop when i = 3");
                    break;
                }
                Console.WriteLine("i = " + i);
            }
        }

        static void ContinueExample()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Skipping value 3 using continue");
                    continue;
                }
                Console.WriteLine("i = " + i);
            }
        }


        static void GotoExample()
        {
            int num = 1;
        Start:
            Console.WriteLine("Number: " + num);
            num++;
            if (num <= 3)
            {
                goto Start;
            }
        }

        static void ReturnExample()
        {
            Console.WriteLine("This method will end early using the return statement.");
            return;
        }

        //static void ThrowExample()
        //{
        //    Console.WriteLine("This will throw an exception.");
        //    //throw new Exception("Custom exception thrown for demonstration."); 
        //}
    }
}


