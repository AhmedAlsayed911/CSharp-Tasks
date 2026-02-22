namespace SeriesMath
{
    internal class Program
    {
        public static void PrintNextNumberInSeries(ISeries series)
        {
            Console.WriteLine(series.GetNextNumber());
        }
        static void Main(string[] args)
        {
            ISeries e = new OddSeries();

            for (int i = 0; i < 10; i++)
                PrintNextNumberInSeries(e);
        }
    }
}
