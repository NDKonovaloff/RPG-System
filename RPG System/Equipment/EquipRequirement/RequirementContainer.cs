using RPG.Character;

namespace RPG.EquipRequirement;

public class RequirementContainer {
    public RequirementContainer(IEquipRequirement? requirements) {
        _Requirements = requirements;
    }

    private IEquipRequirement? _Requirements { get; init; }
    
    public bool Check(ICharacter character) {
        if (_Requirements is null) return true;
        return _Requirements.Check(character);
    }

    public string GetRequirementFailureMessage() {
        if (_Requirements is null) return "";
        return _Requirements.RequirementFailureMessage;
    } 
}