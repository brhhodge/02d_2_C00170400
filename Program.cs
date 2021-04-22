// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02d_2

using System;
using _02d_1_C00170400;

namespace _02d_2_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            Dirt sample = new Dirt();
            Dirt sample2 = new Dirt{Grams_clay = 5.0, Grams_sand = 3.5};
            Dirt sample3 = new Dirt{Grams_clay = 4.5, Grams_sand = 5.5};
            Dirt sample4 = new Dirt{Grams_clay = 2.5, Grams_sand = 1.5};
            Dirt sample5 = new Dirt{Grams_clay = 1.5, Grams_sand = 2.5};


            Console.WriteLine(sample.GetSum());
            Console.WriteLine(sample2.GetSum());
            Console.WriteLine(sample3.GetSum());
            Console.WriteLine(sample4.GetSum());
            Console.WriteLine(sample5.GetSum());

            Console.WriteLine();

            Console.WriteLine(sample == sample2);
            Console.WriteLine(sample2 == sample3);
            Console.WriteLine(sample3 == sample4);
            Console.WriteLine(sample4 == sample5);

            Console.WriteLine();

            Console.WriteLine(sample != sample2);
            Console.WriteLine(sample2 != sample3);
            Console.WriteLine(sample3 != sample4);
            Console.WriteLine(sample4 != sample5);

        }
    }

    static class DirtExtension
    {
        public static double GetSum(this Dirt dirtSample)
        {
            return dirtSample.Grams_clay + dirtSample.Grams_sand;
        }
    }
}
