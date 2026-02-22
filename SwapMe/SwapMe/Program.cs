namespace SwapMe
{
    internal class Program
    {
        public static void Swap<T>(ref T x , ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int x = 5, y = 6;
            Console.WriteLine($"Before Swap x = {x} , y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"After  Swap x = {x} , y = {y}");
        }
    }
}
