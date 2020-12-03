using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day3
{
    public class Map
    {
        public List<Line> Lines;

        public Map()
        {
            this.Lines = new List<Line>();
            var reader = new StreamReader("input.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                var l = new Line();
                l.LineText = line.ToString();
                this.Lines.Add(l);
            }
        }
    }

    public class Line
    {
        public string LineText { get; set; }
        public int  GetIndex(int index)
        {
            var cI = 0;

            if(index >= 0)
            {
                for (int i = 0; i < index; i++)
                {
                    cI++;

                    if(cI > this.LineText.Length - 1)
                    {
                        cI = 0;
                    }
                }
            }
            else
            {
                cI = LineText.Length;
                for (int i = index - 1; i >= 0; i--)
                {
                    cI--;
                    if(cI < 0)
                    {
                        cI = LineText.Length;
                    }
                }
            }

            return cI;
        }
    }
}
