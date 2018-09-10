using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Your name is {0}.", name);
            Console.WriteLine("Your age is {0} years old.", age);

            Console.ReadKey();
        }
    }
}
