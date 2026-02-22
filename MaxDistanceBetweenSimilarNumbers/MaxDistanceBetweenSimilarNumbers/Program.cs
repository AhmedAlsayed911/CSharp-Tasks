using System.Diagnostics;

namespace MaxDistanceBetweenSimilarNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            Console.Write("Enter the size of array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for(int i=0; i<size; i++)
            {
                Console.Write($"Enter item #{i + 1} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxDistance = 0;
            for(int i=0; i<size; i++)
            {
                for(int j = i+1;j<size; j++)
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
