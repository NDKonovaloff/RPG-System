using RPG.Character;

namespace RPG.EquipRequirement;

abstract class StatRequirement : IEquipRequirement {
    public StatRequirement(float requiredValue) {
        RequiredValue = requiredValue;
    }

    public float RequiredValue { get; init; }
    abstract protected string StatName { get; }
    public string RequirementFailureMessage { get; private set; } = "";

    abstract protected float GetCharacterStatValue(ICharacter target);

    public bool Check(ICharacter character) {
        bool res = GetCharacterStatValue(character) >= RequiredValue;

        if (!res) {
            RequirementFailureMessage =
                $"Необходимо {StatName} {RequiredValue} - текущее значение {GetCharacterStatValue(character)}.";
        }

        return res;
    }

    public override string ToString() => $"- Необходимо {StatName} {RequiredValue}";
}
