using RPG.Character;

namespace RPG.EquipRequirement;

class StrengthRequirement : StatRequirement {
    public StrengthRequirement(float requiredValue) : base(requiredValue) { }

    protected override string StatName => "Сила";
    protected override float GetCharacterStatValue(ICharacter target) => target.Stats.Strength;
}
