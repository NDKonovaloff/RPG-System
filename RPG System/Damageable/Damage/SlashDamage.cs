namespace RPG.Damageable;

public readonly struct SlashDamage : IDamage {
    public SlashDamage(float value) {
        Value = value;
    }

    public float Value { get; }

    public float ReduceByResistance(ResistanceStats resistance) {
        return Math.Max(Value - resistance.SlashResistance, 0f);
    }
}
