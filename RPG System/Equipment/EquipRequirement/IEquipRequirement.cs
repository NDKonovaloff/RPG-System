using RPG.Character;

namespace RPG.EquipRequirement;

public interface IEquipRequirement {
    string GetRequirementFailureMessage(ICharacter character);
    bool Check(ICharacter target);
}
