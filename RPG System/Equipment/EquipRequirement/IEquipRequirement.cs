using RPG.Character;

namespace RPG.EquipRequirement;

public interface IEquipRequirement {
    string RequirementFailureMessage { get; }
    bool Check(ICharacter target);
}
