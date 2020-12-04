using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day4.FieldHandler
{
    public class PidHandler: Field
    {
        public PidHandler(): base("pid")
        {

        }

        public override bool IsFieldValid(string line)
        {
            var regex = new Regex(FieldName + ":\\d{9}");

            if (this.IsAvailable(line) && regex.IsMatch(line))
            {
                return true;
            }
            return false;
        }
    }
}
