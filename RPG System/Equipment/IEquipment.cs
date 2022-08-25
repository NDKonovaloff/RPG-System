using RPG.EquipRequirement;

namespace RPG.Equipment;

public interface IEquipment {
    RequirementContainer EquipRequirement { get; }
}