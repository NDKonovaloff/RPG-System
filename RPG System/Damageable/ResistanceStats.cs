namespace RPG.Damageable;

public readonly struct ResistanceStats {
    public ResistanceStats(
        float damageResistance = 1f,
        float slashResistance = 1f,
        float magicResistance = 1f,
        float pierceResistance = 1f
    ) {
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