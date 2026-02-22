namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Complex(5);

            c[0] = 4;
            c[1] = 10;

            Console.Write(c.ToString());
        }
    }
}
