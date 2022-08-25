using RPG.EquipRequirement;

namespace RPG.Equipment;

public interface IEquipment {
    IEquipRequirement EquipRequirement { get; }
}