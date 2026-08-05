namespace CSharpFundamentals
{
    public record PersonRecord(string Name, int Age);
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
    public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
    }
    public class ValueAndReferenceTypes
    {
        public static void Run()
        {
            // experiment 1
            int a = 1;
            int b = a;
            b = 3;

            Console.WriteLine(a);
            Console.WriteLine(b);
            // The behavior I expect it that it will only change b but not a
            // I was correct

            // experiment 2
            Coords c = new Coords(1, 2);
            Coords d = new Coords(3, 4);
            c = d;
            d.Y = 5;
            Console.WriteLine();
            Console.WriteLine(c.X);
            Console.WriteLine(c.Y);
            Console.WriteLine(d.X);
            Console.WriteLine(d.Y);

            // I expect the values to be the same
            // they were not

            // experiment 3
            Person p = new Person("pablo");
            Person j = new Person("jessica");
            p = j;
            j.Name = "maiara";
            Console.WriteLine();
            Console.WriteLine(p.Name);
            Console.WriteLine(j.Name);

            // I expected the names to change because the assign of classes is by reference
            // correct

            PersonRecord ap = new("pablo", 23);
            PersonRecord jp = ap with {Name = "jessica"};
            Console.WriteLine();
            Console.WriteLine(ap.Name);
            Console.WriteLine(jp.Name);

            // // I expect ap.Name to remain "pablo" and jp.Name to be "jessica".
            // Correct
        }
    }
}
