using System.Text;
using RPG.Character;

namespace RPG.EquipRequirement;

class EquipRequirementsContainer : IEquipRequirement {
    private readonly List<IEquipRequirement> _requirements = new();
    private string _requirementFailureMessage = "";

    public EquipRequirementsContainer(List<IEquipRequirement> requirements) {
        _requirements = requirements;
    }

    public EquipRequirementsContainer Add(IEquipRequirement requirement) {
        _requirements.Add(requirement);
        return this;
    }

    public bool Check(ICharacter character) {
        var res = _requirements
            .Where(req => req.Check(character) is false)
            .Select(req => req.GetRequirementFailureMessage(character));

        if (res.Any()) {
            StringBuilder stringBuilder = new("Персонаж не соответствует требованиям экипировки.");

            foreach (var message in res) {
                stringBuilder.AppendLine(message);
            }

            _requirementFailureMessage = stringBuilder.ToString();

            return false;
        }

        return true;
    }

    public string GetRequirementFailureMessage(ICharacter character) => _requirementFailureMessage;

    public override string ToString() {
        StringBuilder stringBuilder = new();
        foreach (var req in _requirements) {
            stringBuilder.Append(req.ToString());
        }
        return stringBuilder.ToString();
    }
}