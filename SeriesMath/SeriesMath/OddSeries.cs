namespace SeriesMath
{
    internal class OddSeries : ISeries
    {
        int nxtNumber = 1;
        public int GetNextNumber()
        {
            int d = nxtNumber;
            nxtNumber += 2;
            return d;
        }
    }
}
