using RPG.Character;

namespace RPG.EquipRequirement;

class DexterityRequirement : StatRequirement {
    public DexterityRequirement(float requiredValue) : base(requiredValue) { }

    protected override string StatName => "Ловкость";
    protected override float GetCharacterStatValue(ICharacter target) => target.Stats.Dexterity;
}
