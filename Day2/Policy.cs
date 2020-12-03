using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day2
{
    public class Policy
    {
        public Policy(string Line)
        {
            var minPatter = new Regex(@"\d*-");
            var maxPatter = new Regex(@"-\d*");
            var charPatter = new Regex(@".:");
            var passWdPattern = new Regex(@":.*");

            string value = minPatter.Match(Line).Value;
            this.MinAmount = Int32.Parse(value.Substring(0, value.Length - 1));

            value = maxPatter.Match(Line).Value;
            this.MaxAMount = Int32.Parse(value.Substring(1));

            value = charPatter.Match(Line).Value;
            this.Character = char.Parse(value.Substring(0, value.Length - 1));

            value = passWdPattern.Match(Line).Value;
            this.PassWd = value.Substring(1);
        }

        public int MinAmount;
        public int MaxAMount;
        public char Character;
        public string PassWd;
    }
}
