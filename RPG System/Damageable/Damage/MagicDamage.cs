namespace RPG.Damageable;

public readonly struct MagicDamage : IDamage {
    public MagicDamage(float value) {
        Value = value;
    }

    public float Value { get; }
    public float ReduceByResistance(ResistanceStats resistance) {
        return Math.Max(Value - resistance.MagicResistance, 0f);
    }
}
