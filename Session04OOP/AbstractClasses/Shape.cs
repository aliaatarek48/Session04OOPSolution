namespace Session04OOP.AbstractClasses
{
    // 1. abstract class = a "half-built" base class.
    // 2. You CANNOT create an object from it
    // 3. it only exists to be inherited and to force a shared contract.

    internal abstract class Shape
    {
        // Constructor  -> abstract classes CAN have constructors called by the derived class to set shared state
        protected Shape(string color)
        {
            Color = color;
        }

        // Property -> shared STATE lives in the base class
        public string Color { get; set; }

        // Abstract members -> NO body. Every child MUST override them.
        // "Each shape knows its own area, but I (the base) don't."
        public abstract double Area();
        public abstract double Perimeter();

        // Virtual member -> HAS a body, but a child MAY override it.
        public virtual void Describe()
        {
            Console.WriteLine($"I am a shape with color {Color}");
        }

        // Concrete member -> shared behavior for ALL children.
        // The base defines the "how to display", children fill the details (Notice it calls the abstract Area()/Perimeter())
        public void Display()
        {
            Console.WriteLine($"[{GetType().Name}] Color = {Color}");
            Console.WriteLine($"   Area      = {Area():F2}");
            Console.WriteLine($"   Perimeter = {Perimeter():F2}");
        }
    }
}
