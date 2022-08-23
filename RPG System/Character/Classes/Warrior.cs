using RPG.Weapons;

namespace RPG.Classes;
class Warrior : ICharacterClass {
    private static readonly WeaponProficiency _BaseWeaponProficiencies = new WeaponProficiency(WeaponType.Melee);
    public WeaponProficiency WeaponProficiency => _BaseWeaponProficiencies;

    public override string ToString() => "Warrior";
}