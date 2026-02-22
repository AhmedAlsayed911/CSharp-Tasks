using System.Diagnostics;

namespace Phrase_Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            var str = Console.ReadLine();
            string[] splitedStr = str.Split(' ');
            Array.Reverse(splitedStr);
            Console.WriteLine(string.Join(" ", splitedStr));
            sw.Stop();
        }
    }
}
