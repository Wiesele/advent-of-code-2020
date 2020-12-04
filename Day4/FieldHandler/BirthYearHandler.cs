using System.Linq;
using System.Text.RegularExpressions;

namespace Day4.FieldHandler
{
    public class YearHandler: Field
    {
        public int MinYear;
        public int MaxYear;
        public YearHandler(string FieldName, int minYear, int maxYear): base(FieldName, false)
        {
            this.MinYear = minYear;
            this.MaxYear = maxYear;
        }

        public override bool IsFieldValid(string line)
        {
            var regex = new Regex(FieldName + ":" + "\\d*");

            if (this.IsAvailable(line))
            {
                var s = regex.Match(line).Value;
                var splitted = s.Split(":");

                if(splitted[1].Length == 4)
                {
                    var i = int.Parse(splitted[1]);
                    if(Enumerable.Range(MinYear, (MaxYear - MinYear) + 1).Contains(i))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}