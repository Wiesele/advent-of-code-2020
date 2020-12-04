using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day4.FieldHandler
{
    public class EyeColorHandler : Field
    {
        public EyeColorHandler(): base("ecl")
        {

        }

        public override bool IsFieldValid(string line)
        {
            var regex = new Regex(FieldName + ":(amb|blu|brn|gry|grn|hzl|oth){1}");

            if (this.IsAvailable(line) && regex.IsMatch(line))
            {
                return true;
            }
            return false;
        }
    }
}
