using RPG.Character;

namespace RPG.EquipRequirement;

abstract class StatRequirement : IEquipRequirement {
    public StatRequirement(float requiredValue) {
        RequiredValue = requiredValue;
    }

    public float RequiredValue { get; init; }
    public bool Check(ICharacter target) => GetCharacterStatValue(target) >= RequiredValue;

    abstract protected string StatName { get; }
    abstract protected float GetCharacterStatValue(ICharacter target);

    public string GetRequirementFailureMessage(ICharacter character) =>
        $"Необходимо {StatName} {RequiredValue} - текущее значение {GetCharacterStatValue(character)}.";

    public override string ToString() => $"- Необходимо {StatName} {RequiredValue}";
}
