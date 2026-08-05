namespace Session04OOP.AbstractClasses
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        // Child constructor passes the shared part (color) up to the base
        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        // MUST override the abstract members (compiler forces us)
        public override double Area() => Math.PI * Radius * Radius;
        public override double Perimeter() => 2 * Math.PI * Radius;

        public override void Describe()
        {
            Console.WriteLine($"I am a circle with radius {Radius}");
        }
    }
}
