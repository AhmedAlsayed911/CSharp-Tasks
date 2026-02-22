namespace SeriesMath
{
    internal class EvenSeries : ISeries
    {
        int nxtNumber = 0;
        public int GetNextNumber()
        {
            int d = nxtNumber;
            nxtNumber += 2;
            return d;
        }
    }
}
