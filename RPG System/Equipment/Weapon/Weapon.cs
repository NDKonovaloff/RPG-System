using RPG.Equipment;
using RPG.EquipRequirement;

namespace RPG.Weapons;

public class Weapon : IEquipment {
    public Weapon(string name, float damageValue, WeaponType weaponType, IEquipRequirement? equipRequirement) {
        Name = name;
        DamageValue = damageValue;
        WeaponType = weaponType;
        EquipRequirement = new(equipRequirement);
    }

    public string Name { get; init; }
    public float DamageValue { get; init; }
    public WeaponType WeaponType { get; init; }
    public RequirementContainer EquipRequirement { get; init; }

    public override string ToString() => $"{Name}";
}
