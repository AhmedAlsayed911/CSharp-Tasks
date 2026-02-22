using System.Diagnostics;

namespace MaxDistanceBetweenSimilarNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            int[] arr = { 1, 1, 5, 6, 7, 4, 9, 1 };

            int maxDistance = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if ((j - i) > maxDistance)
                            maxDistance = j - i - 1;
                    }
                }
            }

            Console.WriteLine($"Max Distance : {maxDistance}");

            sw.Stop();

            Console.WriteLine($"Task takes {sw.ElapsedMilliseconds} Milliseconds");
        }
    }
}
