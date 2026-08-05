using Session04OOP.AbstractVsInterface.AbstractClass;

namespace Session04OOP.AbstractVsInterface.Classes
{
    // Intern IS-A Employee, but does NOT implement IBonusEligible
    internal class Intern : Employee
    {
        public decimal Stipend { get; set; }

        public Intern(int id, string name, decimal stipend) : base(id, name)
        {
            Stipend = stipend;
        }
        public override decimal CalculateSalary() => Stipend;

    }
}
