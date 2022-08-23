using RPG.Classes;

namespace RPG.Character;
class Character : ICharacter {
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

    public Inventory Inventory => new Inventory();

    public override string ToString() {
        return $"{Name}, {Class}\n{Health}";
    }
}
