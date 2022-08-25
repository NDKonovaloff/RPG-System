namespace RPG.Damageable;

public interface IDamage {
    float Value { get; }

    float ReduceByResistance(ResistanceStats resistance);
}
