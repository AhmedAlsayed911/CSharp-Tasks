using System.Security.Cryptography.X509Certificates;

namespace PointHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Point(1);
            //Console.WriteLine(p.ToString());

            //string s = p; // cannot Implicitly convert 3D Point to string Type
            //string s = (string)p; // cannot Explicitly convert 3D Point to string Type

            //Point[] points = new Point[2];

            //for (int i = 0; i < 2; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine($"Enter Point {i + 1}:");

            //        int x = int.Parse(Console.ReadLine());
            //        int y = int.Parse(Console.ReadLine());
            //        int z = int.Parse(Console.ReadLine());

            //        points[i] = new Point(x, y, z);
            //    }
            //    catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //}

            //int i = 0;
            //Point[] Points2 = new Point[2];

            //do
            //{
            //    Console.WriteLine($"Enter Dimensions of Point {i + 1}:");

            //    Console.Write("X: ");
            //    bool okX = int.TryParse(Console.ReadLine(), out int x);

            //    Console.Write("Y: ");
            //    bool okY = int.TryParse(Console.ReadLine(), out int y);

            //    Console.Write("Z: ");
            //    bool okZ = int.TryParse(Console.ReadLine(), out int z);

            //    if (!(okX && okY && okZ))
            //    {
            //        Console.WriteLine("Invalid input! Please enter integers only.\n");
            //        continue;
            //    }

            //    Points2[i] = new Point(x, y, z);
            //    i++;

            //} while (i < 2);

            //Console.WriteLine(Points2[0].ToString());

            //var points3 = new Point[2];
            //int x, y, z;
            //for (int i = 0; i < 2; i++)
            //{
            //    try
            //    {
            //        Console.Write($"Enter x of Point {i + 1} : ");
            //        x = Convert.ToInt32(Console.ReadLine());

            //        Console.Write($"Enter y of Point {i + 1} : ");
            //        y = Convert.ToInt32(Console.ReadLine()); ;

            //        Console.Write($"Enter z of Point {i + 1} : ");
            //        z = Convert.ToInt32(Console.ReadLine());

            //        points3[i] = new Point(x, y, z);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"{e.Message}");
            //    }
            //}

            //Console.WriteLine(points3[0].ToString());

            //Console.WriteLine(Points2[0] == Points2[1]); // false ref != ref.
            //Console.WriteLine(Points2[0].Equals(Points2[1])); // true value = value.

            var points = new Point[5] {new Point(1,4,3)
                , new Point(1, 2, 3)
                , new Point(0, 2, 3)
                , new Point(8, 2, 3)
                , new Point(9, 2, 3) };

            Array.Sort(points);

            foreach (var itme in points)
                Console.WriteLine(itme.ToString());
        }
    }
}
