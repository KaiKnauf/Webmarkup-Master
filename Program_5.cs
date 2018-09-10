using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int number1 = rnd.Next(101, 10000);
            Console.WriteLine("Your first random number is {0}", number1);

            int number2 = rnd.Next(101, 10000);
            Console.WriteLine("Your second random number is {0}", number2);

            int number3 = rnd.Next(101, 10000);
            Console.WriteLine("Your third random number is {0}", number3);

            int number4 = rnd.Next(101, 10000);
            Console.WriteLine("Your fourth random number is {0}", number4);
            
            int calc;
            calc = number1 + number2 + number3 + number4;

            string totalNumber = (calc).ToString();
            Console.WriteLine("If you add all those numbers, you'll get the following number: {0}", totalNumber);

            //bool awnser;
            //awnser = (number1 + number2 + number3 + number4 = calc);

            Console.ReadKey();
        }
    }
}
