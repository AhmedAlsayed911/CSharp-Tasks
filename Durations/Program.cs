namespace Durations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Duration(1, 60, 50);
            Console.WriteLine(d.ToString());

            var d2 = new Duration(666);
            Console.WriteLine(d2.ToString());

            var d3 = d + d2;
            Console.WriteLine(d3.ToString());

            var d4 = d + 7800;
            Console.WriteLine(d4.ToString());

            var d5 = 7800 + d;
            Console.WriteLine(d5.ToString());

            --d;
            Console.WriteLine(d.ToString());

            DateTime dt = (DateTime)d;
            Console.WriteLine(dt.ToString("h/m/s"));
        }
    }
}
