namespace RPG.Damageable;

public readonly struct ResistanceStats {
    public ResistanceStats(float damageResistance, float slashResistance, float magicResistance, float pierceResistance) {
        DamageResistance = damageResistance;
        SlashResistance = slashResistance;
        MagicResistance = magicResistance;
        PierceResistance = pierceResistance;
    }

    public float DamageResistance { get; }
    public float SlashResistance { get; }
    public float MagicResistance { get; }
    public float PierceResistance { get; }
}