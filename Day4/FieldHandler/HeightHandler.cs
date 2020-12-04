using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Day4.FieldHandler
{
    public class HeightHandler: YearHandler
    {
        public HeightHandler(): base("hgt", 59, 76)
        {

        }

        public override bool IsFieldValid(string line)
        {
            var regex = new Regex(FieldName + ":\\d*(cm|in)");

            if (this.IsAvailable(line) && regex.IsMatch(line))
            {
                
                var s = regex.Match(line).Value;
                var r = new Regex("(\\d)*");
                var matches = r.Matches(s);
                string match = "";

                foreach (var item in matches)
                {
                    if (!string.IsNullOrEmpty(item.ToString()))
                    {
                        match = item.ToString();
                        break;
                    }
                }

                var number = int.Parse(match);

                if (s.Contains("cm"))
                {
                    if (Enumerable.Range(150, (193 - 150) + 1).Contains(number))
                    {
                        return true;
                    }
                }
                else
                {
                    if (Enumerable.Range(59, 76 - 59).Contains(number))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
