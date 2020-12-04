using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Day4.FieldHandler
{
    public class HairColorHandler: Field
    {
        public HairColorHandler(): base("hcl")
        {

        }

        public override bool IsFieldValid(string line)
        {

            var regex = new Regex(FieldName + ":#(\\d|[a-f])*");

            if (this.IsAvailable(line) && regex.IsMatch(line))
            {

                var matches = regex.Match(line);
                var splitted = matches.Value.ToString().Split(":");

                if(splitted[1].Length == 7)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
