namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = NIC.GetInstance("test", "255.255.255.0", "testing");
            Console.WriteLine(n.ToString());
        }
    }
}
