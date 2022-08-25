namespace RPG.Damageable;

public readonly struct PierceDamage : IDamage {
    public PierceDamage(float value) {
        Value = value;
    }

    public float Value { get; }

    public float ReduceByResistance(ResistanceStats resistance) {
        return Math.Max(Value - resistance.PierceResistance, 0f);
    }
}