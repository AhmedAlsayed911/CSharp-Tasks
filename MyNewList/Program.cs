namespace MyNewList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ml = new MyList<int>(2);

            ml.Add(1);
            ml.Add(2);
            ml.Add(3);
            ml.Print();

            ml.Remove(2);
            ml.Print();

            Console.WriteLine("\n------------------------------------------------------\n");

            var test = new MyList<string>(2);

            test.Add("ahmed");
            test.Add("ahmed");
            test.Add("sayed");
            test.Add("zain");
            test.Print();

            test.Remove("zain");
            test.Print();

            Console.WriteLine("\n------------------------------------------------------\n");

            var complexes = new MyList<Complex>(2);

            complexes.Add(new Complex(5, 6));
            complexes.Add(new Complex(3, 4));

            complexes.Print();
            complexes.Remove(new Complex(5, 6));
            complexes.Print();
            Console.WriteLine("\n------------------------------------------------------\n");

            var indexerTesting = new MyList<int>(2);
            indexerTesting.Add(1);
            indexerTesting.Add(2);
            Console.WriteLine(indexerTesting[0]);
            Console.WriteLine("\n------------------------------------------------------\n");

            foreach (var item in test)
                Console.WriteLine(item);

            Console.WriteLine("\n------------------------------------------------------\n");

            var one = test.Find(x => x == "Khaled");
            Console.WriteLine(one);

            Console.WriteLine("\n------------------------------------------------------\n");

            var all = test.FindAll(x => x == "ahmed");
            foreach (var item in all)
                Console.WriteLine(item);
        }
    }
}
