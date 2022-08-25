namespace RPG.Damageable;

public readonly struct RegularDamage : IDamage {
    public RegularDamage(float value) {
        Value = value;
    }

    public float Value { get; }

    public float ReduceByResistance(ResistanceStats resistance) {
        return Math.Max(Value - resistance.DamageResistance, 0f);
    }
}
