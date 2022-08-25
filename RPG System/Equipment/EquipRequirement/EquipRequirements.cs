using System.Text;
using RPG.Character;

namespace RPG.EquipRequirement;

class EquipRequirements : IEquipRequirement {
    public EquipRequirements(List<IEquipRequirement> requirements) {
        _requirements = requirements.ToArray();
    }
    
    private readonly IEquipRequirement[] _requirements;
    public string RequirementFailureMessage { get; private set; } = "";

    public bool Check(ICharacter character) {
        var res = _requirements
            .Where(req => req.Check(character) is false)
            .Select(req => req.RequirementFailureMessage);

        if (res.Any()) {
            StringBuilder stringBuilder = new("Персонаж не соответствует требованиям экипировки.");

            foreach (var message in res) {
                stringBuilder.AppendLine(message);
            }

            RequirementFailureMessage = stringBuilder.ToString();

            return false;
        }

        return true;
    }


    public override string ToString() {
        StringBuilder stringBuilder = new();
        foreach (var req in _requirements) {
            stringBuilder.Append(req.ToString());
        }
        return stringBuilder.ToString();
    }
}