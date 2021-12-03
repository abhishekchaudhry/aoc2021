using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace aoc2021
{
    public class abhi
    {
        static void Main(string[] args)
        {
            string[] textlines = File.ReadAllLines("../../../../../../input/day1.txt");
            //Console.WriteLine(textlines);
            int i = 0;
            //int next = 0;
            int counter = 0;
            for (i = 0; i < textlines.Length; i++)
            {
                //Console.WriteLine(textlines[i+1]);
                if ((i + 1) <= textlines.Length)
                {
                    if (Int16.Parse(textlines[i + 1]) > Int16.Parse(textlines[i]))
                    {
                        counter++;
                    }
                }
                    
                //Console.WriteLine(next);
                Console.WriteLine((counter));
            }
        }
    }
}