using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 200;
            int level = 3;
            int nItems = 4;

            int score_new, level_new;

            // increase score and level
            score_new = 1 + score;
            level_new = 1 + level;

            Console.WriteLine("Score (old): {0}, score (new): {1}", score, score_new);
            Console.WriteLine("level (old): {0}, level (new): {1}", level, level_new);

            nItems += 5;
            Console.WriteLine("number of items: {0}", nItems);

            // wait for user to press a key
            Console.ReadKey();

            //6. ++var will immediatly be executed, while var++ will be executed when found in a later statment

        }
    }
}
