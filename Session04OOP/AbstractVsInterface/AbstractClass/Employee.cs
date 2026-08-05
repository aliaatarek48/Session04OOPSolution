namespace Session04OOP.AbstractVsInterface.AbstractClass
{
    internal abstract class Employee
    {
        // Shared STATE
        public int Id { get; set; }
        public string Name { get; set; }

        protected Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Shared BEHAVIOR
        public void GetInfo()
        {
            Console.WriteLine($"#{Id} {Name} ({GetType().Name})");
        }

        // Each employee type MUST define its own salary rule
        public abstract decimal CalculateSalary();
    }
}
