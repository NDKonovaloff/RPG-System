using RPG.Damageable;
using RPG.Equipment;
using RPG.EquipRequirement;

namespace RPG.Weapons;

public class Weapon : IEquipment {
    public Weapon(string name, DamageContainer damage, WeaponType weaponType, IEquipRequirement? equipRequirement) {
        Name = name;
        Damage = damage;
        WeaponType = weaponType;
        EquipRequirement = new(equipRequirement);
    }

    public string Name { get; init; }
    public DamageContainer Damage { get; init; }
    public WeaponType WeaponType { get; init; }
    public RequirementContainer EquipRequirement { get; init; }

    public override string ToString() => $"{Name}";
}
