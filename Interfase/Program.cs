namespace Interfaces
{
    interface ICalc
    {
        public int Less(int valueToCompare);
        public int Greater(int valueToCompare);
    }
    interface ICalc2
    {
        public int CountDistinct();
        public int EqualToValue(int valueToCompare);
    }
    interface IOutput2
    {
        public string ShowEven();
        public string ShowOdd();
    }
}