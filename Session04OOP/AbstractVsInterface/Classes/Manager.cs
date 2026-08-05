using Session04OOP.AbstractVsInterface.AbstractClass;
using Session04OOP.AbstractVsInterface.Enums;
using Session04OOP.AbstractVsInterface.Interfaces;

namespace Session04OOP.AbstractVsInterface.Classes
{
    // Manager IS-A Employee (abstract class)  AND  CAN earn a bonus (interface).
    internal class Manager : Employee, IBonus
    {
        public decimal BaseSalary { get; set; }

        public BonusType BonusType => BonusType.Managerial;
        public Manager(int id, string name, decimal baseSalary) : base(id, name)
        {
            BaseSalary = baseSalary;
        }

        public override decimal CalculateSalary() => BaseSalary;
        public decimal CalculateBonus() => BaseSalary * 0.20m;
    }
}
