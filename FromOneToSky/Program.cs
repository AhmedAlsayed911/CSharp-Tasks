using System.Diagnostics;
using System.Text;

namespace FromOneToSky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            long counter = 0;
            var sb = new StringBuilder();

            for (long i = 1; i < 99999999; i++) 
            {
                sb.Append(i).ToString();
                for(int j=0; j<sb.Length; j++)
                {
                    if (sb[j] == '1')
                        counter++;
                }
                sb.Clear();
            }
            Console.WriteLine($"it has {counter} ones");
            sw.Stop();
            Console.WriteLine($"Task takes {sw.ElapsedMilliseconds} Milliseconds");
        }
    }
}
