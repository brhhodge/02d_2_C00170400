// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02d_2

using System;

namespace _02d_1_C00170400
{
    class Dirt
    {
        private double grams_sand = 1; // 2 private data member fields for amount in grams of clay and sand in sample
        private double grams_clay = 1; // "  "

        public double Grams_clay { get => grams_clay; set => grams_clay = value; } // public properties for each private data member
        public double Grams_sand { get => grams_sand; set => grams_sand = value; } // "  "


        public override string ToString()
        {
            return ("This sample has " + this.Grams_clay + " grams of clay, and  " + this.Grams_sand + " grams of sand");
        }

        public override bool Equals(object obj)
        {
            return this == (Dirt)obj;
        }

        // "==" Operator overload method
        public static bool operator == (Dirt sample_1, Dirt sample_2)
        {
            return (((sample_1.Grams_clay == sample_2.Grams_clay) || (sample_1.Grams_sand == sample_2.Grams_sand))
                || ((sample_1.Grams_clay == sample_2.Grams_sand) || (sample_2.Grams_clay == sample_1.Grams_sand)));
        }


        // "!=" Operator overload method
        public static bool operator != (Dirt sample_1, Dirt sample_2)
        {
            return ((sample_1.Grams_clay + sample_1.Grams_sand) != (sample_2.Grams_clay + sample_2.Grams_sand));
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}