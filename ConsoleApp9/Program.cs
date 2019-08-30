using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    FizzBuzzCheck();

                }
                else if (i % 5 == 0)
                {
                    BuzzCheck();
                }
                else if (i % 3 == 0)
                {
                    FizzCheck();
                    
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();

        }

        static public void FizzCheck()
        {
            Console.WriteLine("Fizz");

        }
        static public void BuzzCheck()
        {
            Console.WriteLine("Buzz");

        }
        static public void FizzBuzzCheck()
        {
            Console.WriteLine("FizzBuzz");

        }
    }
}

// Buzz for Multiples of 5
// Fizz for Multiples of 3