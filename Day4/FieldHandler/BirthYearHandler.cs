namespace Day4
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
            throw new System.NotImplementedException();
        }
    }
}