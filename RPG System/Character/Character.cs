using RPG.Classes;
using RPG.Damageable;
using RPG.Weapons;

namespace RPG.Character;
public class Character : ICharacter, IDamageable {
    public Character(string name, Health health, ManaPool mana, Stats stats, ICharacterClass @class) {
        Name = name;
        Health = health;
        Stats = stats;
        Class = @class;
        Mana = mana;
    }

    public string Name { get; init; }
    public Stats Stats { get; init; }
    public Health Health { get; init; }
    public ManaPool Mana { get; init; }
    public ICharacterClass Class { get; init; }

    public Inventory Inventory => new();

    public void EquipWeapon(Weapon weapon) {
        Inventory.EquippedWeapon = weapon;
    }

    public void Attack(IDamageable target) {
        if (Inventory.EquippedWeapon is null) return;
        var hit = new Hit(target, Inventory.EquippedWeapon.Damage);
        target.TakeDamage(hit);
    }

    public void TakeDamage(Hit hit) {
        if (Health.IsDead) return;
        Health.Reduce(hit.TotalDamage);
    }

    public override string ToString() {
        return $"{Name}, {Class}";
    }

    public ResistanceStats GetResistance() {
        return new ResistanceStats();
    }
}
