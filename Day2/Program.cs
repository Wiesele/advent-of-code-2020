using System;
using System.IO;
using System.Linq;

namespace Day2
{
    class Program
    {
        public static int FalsePwCount = 0;

        static void Main(string[] args)
        {
            ReadInputList();
        }

        public static void ReadInputList()
        {
            var reader = new StreamReader("input.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                FalsePwCount += IsLineValid(line.ToString()) ? 1 : 0;
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
            Console.WriteLine("Found " + FalsePwCount + " valid passwords");
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("----------------------");
            Console.WriteLine("--------Day 2---------");
            Console.WriteLine("----------------------");

            Console.WriteLine("");
            Console.WriteLine("");


            FalsePwCount = 0;

            reader = new StreamReader("input.txt");

            while ((line = reader.ReadLine()) != null)
            {
                FalsePwCount += IsLineValid2(line.ToString()) ? 1 : 0;
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
            Console.WriteLine("Found " + FalsePwCount + " valid passwords");
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");

        }

        /// <summary>
        /// First Half
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static bool IsLineValid(string line)
        {
            var p = new Policy(line);
            int count = 0;
            foreach (char item in p.PassWd)
            {
                if(item == p.Character)
                {
                    count++;
                }

            }

            if(Enumerable.Range(p.MinAmount, (p.MaxAMount - p.MinAmount) + 1).Contains(count))
            {
                Console.WriteLine(line + " - valid");
                return true;
            }
            Console.WriteLine(line + " - not valid");
            return false;

        }

        /// <summary>
        /// Second Half
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static bool IsLineValid2(string line)
        {
            var p = new Policy(line);
            int count = 0;

            var c1 = p.PassWd.Trim()[p.MinAmount - 1];
            var c2 = p.PassWd.Trim()[p.MaxAMount - 1];

            if(c1 == c2)
            {
                Console.WriteLine(line + " - not valid (same char)");
                return false;
            }
            else if(c1 == p.Character ||c2 == p.Character)
            {
                Console.WriteLine(line + " - valid");
                return true;
            }
            Console.WriteLine(line + " - not valid (no char)");
            return false;
        }
    }
}
