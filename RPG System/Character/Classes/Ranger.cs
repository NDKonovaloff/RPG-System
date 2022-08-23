using RPG.Weapons;

namespace RPG.Classes;

class Ranger : ICharacterClass {
    private static readonly WeaponProficiency _BaseWeaponProficiencies = new WeaponProficiency(WeaponType.Range);
    public WeaponProficiency WeaponProficiency => _BaseWeaponProficiencies;

    public override string ToString() => "Ranger";
}
