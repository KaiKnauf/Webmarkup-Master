using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            bool answer;
            answer = (5 != 3);
            Console.WriteLine("boolean answer: {0}", answer);
*/

            //Exercise 4.5/4.6/4.7
            string input;
            bool tooOld;

            Console.WriteLine("Enter your age please: ");
            input = Console.ReadLine();

            int age = int.Parse(input);

            tooOld = (age >= 65);

            Console.WriteLine("Is it true you are too old: {0}", tooOld);
            
            // wait for user to press a key
            Console.ReadKey();
        }
    }
}
