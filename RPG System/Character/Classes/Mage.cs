using RPG.Weapons;

namespace RPG.Classes;

class Mage : ICharacterClass {
    private static readonly WeaponProficiency _BaseWeaponProficiencies = new WeaponProficiency(WeaponType.Magic);
    public WeaponProficiency WeaponProficiency => _BaseWeaponProficiencies;

    public override string ToString() => "Mage";
}