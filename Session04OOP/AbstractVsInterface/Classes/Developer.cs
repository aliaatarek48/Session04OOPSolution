using Session04OOP.AbstractVsInterface.AbstractClass;
using Session04OOP.AbstractVsInterface.Enums;
using Session04OOP.AbstractVsInterface.Interfaces;

namespace Session04OOP.AbstractVsInterface.Classes
{
    // Developer IS-A Employee AND CAN earn a bonus (per closed task).

    internal class Developer : Employee, IBonus
    {
        public decimal BaseSalary { get; set; }
        public int ClosedTasks { get; set; }

        public BonusType BonusType => BonusType.Performance;

        public Developer(int id, string name, decimal baseSalary, int closedTasks) : base(id, name)
        {
            BaseSalary = baseSalary;
            ClosedTasks = closedTasks;
        }
        public override decimal CalculateSalary() => BaseSalary;
        public decimal CalculateBonus() => ClosedTasks * 100m;

    }
}
