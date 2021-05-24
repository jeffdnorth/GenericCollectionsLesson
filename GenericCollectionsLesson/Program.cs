using System;
using System.Collections.Generic;

namespace GenericCollectionsLesson
{
    class Program
    {
        static void Main(string[] args)
        { //slide 216  returns random #s  Random # generator to return the #s
          //modify to three games of ten frames each and add up grand total ??? not done
            Random rnd = new Random();
            var ints = new List<int>();
            // changing:
            // for (var idx = 0 ;idx < (from ten to 30) changes it from ten frames to 30 frames
            for (var idx = 0; idx < 30; idx++)
            {
                var score = rnd.Next(0, 31);
                ints.Add(score);
            }
            var total = 0;
            //loop for ten bowling frames with random scores
            foreach (var i in ints)
                total = total + i;
            {
                Console.WriteLine($"Total is {total}");
            }
            /*
            //collection grows or shrinks w # of items
            var ints = new List<int>();
            ints.Add(4);
            ints.Add(7);
            ints.Add(15);
            Console.WriteLine($"The ints have {ints.Count} items");
            ints.Remove(7);
            Console.WriteLine($"The ints have {ints.Count} items");
            */
        }
    }
}
