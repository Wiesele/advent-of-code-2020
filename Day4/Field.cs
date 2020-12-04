using System.Linq;
using System.Text.RegularExpressions;

namespace Day4
{
    public abstract class Field
    {
        public string FieldName;
        public bool Optional;
        public Field(string fieldName, bool optional = false)
        {
                this.FieldName = fieldName;
                this.Optional = optional;
        }

        public bool IsAvailable(string input)
        {
            if(this.Optional)
            {
                return true;
            }

            var exp = FieldName + ":";
            var regex = new Regex(exp);

            if(regex.IsMatch(input))
            {
                return true;
            }
            
            return false;
        }

        public abstract bool IsFieldValid(string line);

        public string GetFieldValue(string Line)
        {
            
        }
    }

}