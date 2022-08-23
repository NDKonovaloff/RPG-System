using RPG.Classes;

namespace RPG.Character;

public interface ICharacter {
    Health Health { get; }
    Stats Stats { get; }
    ICharacterClass Class { get; }
}
