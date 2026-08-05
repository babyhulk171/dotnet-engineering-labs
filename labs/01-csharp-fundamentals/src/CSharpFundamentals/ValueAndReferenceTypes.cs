using System.Runtime.InteropServices.Swift;

namespace CSharpFundamentals
{
    public record AnotherPerson(string Name, int Age);
    public class Person
    {
        public Person(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
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
        public static void Main()
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
            c.X = c.Y;
            c.Y = 4;
            Console.WriteLine();
            Console.WriteLine(c.X);
            Console.WriteLine(c.Y);

            // I expect the values to be the same
            // they were not

            // experiment 3
            Person p = new Person("pablo");
            Person j = new Person("jessica");
            p = j;
            j.name = "maiara";
            Console.WriteLine();
            Console.WriteLine(p.name);
            Console.WriteLine(j.name);

            // I expected the names to change because the assign of classes is by reference
            // correct

            AnotherPerson ap = new("pablo", 23);
            AnotherPerson jp = ap with {Name = "jessica"};
            Console.WriteLine();
            Console.WriteLine(ap.Name);
            Console.WriteLine(jp.Name);

            // I expect the names to change with the "with" keyword
            // Correct
        }
    }
}
