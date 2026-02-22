using System.Diagnostics;

namespace FromOneToSky_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            int x;
            int counter = 0;
            for (int i = 1; i < 99999999; i++) 
            {
                x = i;
                while(x > 0)
                {
                    if(x % 10 == 1)
                        counter++;

                    x /= 10;
                }
            }
            sw.Stop();

            Console.WriteLine($"it has {counter} ones");
            Console.WriteLine($"Task takes {sw.ElapsedMilliseconds} Milliseconds");
        }
    }
}
