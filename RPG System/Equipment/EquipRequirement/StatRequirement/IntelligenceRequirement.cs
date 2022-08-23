using RPG.Character;

namespace RPG.EquipRequirement;

class IntelligenceRequirement : StatRequirement {
    public IntelligenceRequirement(float requiredValue) : base(requiredValue) { }
    protected override string StatName => "Интеллект";
    protected override float GetCharacterStatValue(ICharacter target) => target.Stats.Intelligence;
}
