using RPG.Classes;

namespace RPG.Character;

public interface ICharacter {
    Stats Stats { get; }
    ICharacterClass Class { get; }
}
