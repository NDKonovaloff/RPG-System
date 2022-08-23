using RPG.Classes;

namespace RPG.Character;

class CharacterBuilder {
    public string? Name { get; private set; }
    public Health? Health { get; private set; }
    public ManaPool? Mana { get; private set; }
    public Stats Stats { get; private set; }
    public ICharacterClass? Class { get; private set; }

    public CharacterBuilder SetName(string name) {
        ArgumentNullException.ThrowIfNull(name, "name");
        Name = name;
        return this;
    }

    public CharacterBuilder SetHealth(Health health) {
        ArgumentNullException.ThrowIfNull(health);
        Health = health;
        return this;
    }

    public CharacterBuilder SetManaPool(ManaPool mana) {
        ArgumentNullException.ThrowIfNull(mana);
        Mana = mana;
        return this;
    }

    public CharacterBuilder SetStats(Stats stats) {
        Stats = stats;
        return this;
    }

    public CharacterBuilder SetClass(ICharacterClass? @class) {
        ArgumentNullException.ThrowIfNull(@class);
        Class = @class;
        return this;
    }

    public CharacterBuilder Clear() {
        Name = null;
        Health = null;
        Mana = null;
        Stats = default;
        Class = null;

        return this;
    }

    public Character Build() {
        ArgumentNullException.ThrowIfNull(Name);
        ArgumentNullException.ThrowIfNull(Health);
        ArgumentNullException.ThrowIfNull(Mana);
        ArgumentNullException.ThrowIfNull(Class);

        return new Character(Name, Health, Mana, Stats, Class);
    }

    public Character BuildAndClear() {
        var character = Build();
        Clear();
        return character;
    }

}
