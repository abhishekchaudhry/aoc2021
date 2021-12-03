using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace aoc2021
{
    public class Day1
    {
        public static void Run()
        {
            /*//Day1 part 1
            string[] textlines = File.ReadAllLines("../../../../../../input/day1.txt");
            //Console.WriteLine(textlines);
            int i = 0;
            //int next = 0;
            int counter = 0;
            for (i = 1; i < textlines.Length; i++)
            {
                //Console.WriteLine(textlines[i+1]);
                if ((i + 1) <= textlines.Length)
                {
                    if (Int16.Parse(textlines[i]) > Int16.Parse(textlines[i -1]))
                    {
                        counter++;
                    }
                }
                    
                //Console.WriteLine(next);
                Console.WriteLine((counter));
            }*/
            //}

            //Day1 part 2
            
            string[] textlines = File.ReadAllLines("../../../../../../input/day1.txt");
            int[] textint = (Array.ConvertAll(textlines, s => Int32.Parse(s)));
            //Console.WriteLine(textlines);
            
            int counter = 0;
            for (int i = 1; i < textint.Count() - 2; i++)
            {
                long firstsum = textint[i - 1] + textint[i] + textint[i + 1];
                long secsum = textint[i] + textint[i + 1] + textint[i + 2];
                
                if (secsum > firstsum)
                {
                    counter++;
                }

                //Console.WriteLine(next);
            }
            Console.WriteLine((counter));
        }
    }
}