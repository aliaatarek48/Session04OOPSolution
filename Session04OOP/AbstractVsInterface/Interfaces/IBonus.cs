using Session04OOP.AbstractVsInterface.Enums;

namespace Session04OOP.AbstractVsInterface.Interfaces
{
    // INTERFACE = the "CAN-DO" capability (an optional ability).
    // Not every employee earns a bonus, so we do NOT put this in the base class.
    // Only the types that CAN earn a bonus will sign this contract.
    internal interface IBonus
    {
        BonusType BonusType { get; }    // property, type is the enum above
        decimal CalculateBonus();
    }
}
