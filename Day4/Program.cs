using Day4.FieldHandler;
using System;
using System.IO;
using System.Linq;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Starting----");
            var Fields = new Field[]
            {
                new YearHandler("byr", 1920, 2002),
                new YearHandler("iyr", 2010, 2020),
                new YearHandler("eyr", 2020, 2030),
                new HeightHandler(),
                new HairColorHandler(),
                new PidHandler(),
                new EyeColorHandler(),

                //new Field("cid", true)
            };


            var reader = new StreamReader("input.txt");
            string line = "";
            string completeLine = "";
            var validPassports = 0;
            string falseStatement = "";

            while ((line = reader.ReadLine()) != null)
            {
                
                if(string.IsNullOrEmpty(line) || reader.EndOfStream )
                {
                    completeLine += line;
                    var isPassportValid = true;
                    foreach(var field in Fields)
                    {
                        if(!field.IsFieldValid(completeLine))
                        {
                            isPassportValid  = false;
                            falseStatement = field.FieldName;
                            break;
                        }
                        
                    }

                    if(isPassportValid)
                    {
                        validPassports++;
                        Console.WriteLine(completeLine + " - valid");
                    }
                    else
                    {
                        Console.WriteLine(completeLine + " - not valid (" + falseStatement + ")");
                    }

                    completeLine = "";
                }
                else
                {
                    completeLine += " " + line;
                }
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Found " + validPassports + " valid passports");
        }
    }
}
