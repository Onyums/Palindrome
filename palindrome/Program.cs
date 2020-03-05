using System;
using System.Linq;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            bool tf = stitic.Check(word);

            if (tf)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
        
        
    }

    }
