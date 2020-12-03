using System;
using System.Text;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Map();
            var moves = new Move[]
            {
                new Move()
                {
                    Down = 1,
                    Right = 1
                },
                new Move()
                {
                    Down = 1,
                    Right = 3
                },
                new Move()
                {
                    Down = 1,
                    Right = 5
                },
                new Move()
                {
                    Down = 1,
                    Right = 7
                },
                new Move()
                {
                    Down = 2,
                    Right = 1
                }
            };
            long answer = 1;

            foreach (var move in moves)
            {
                var currRight = 0;
                var hitTree = 0;
                var down = 0;


                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");
                Console.WriteLine("Next Move");
                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");

                foreach (var line in m.Lines)
                {
                    if (down % move.Down == 0)
                    {

                        var correctedIndex = line.GetIndex(currRight);
                        if (line.LineText[correctedIndex] == '#')
                        {
                            var sb = new StringBuilder(line.LineText);
                            sb[correctedIndex] = 'X';

                            Console.WriteLine(sb.ToString() + " - " + " hit tree (" + currRight + ")");
                            hitTree++;
                        }
                        else
                        {
                            var sb = new StringBuilder(line.LineText);
                            sb[correctedIndex] = 'O';

                            Console.WriteLine(sb.ToString() + " - " + " hit no tree (" + currRight + ")");
                        }
                        currRight = currRight + move.Right;
                    }
                    else
                    {
                        Console.WriteLine(line.LineText + " - " + " skipped line");
                    }
                    down++;
                }

                answer = answer * hitTree;
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
            Console.WriteLine("Hit " + answer + " trees");
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
        }

        public class Move
        {
            public int Down;
            public int Right;
        }
    }
}
