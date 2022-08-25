namespace RPG.Damageable;

public interface IDamageable {
    void TakeDamage(Hit hit);
    ResistanceStats GetResistance();
}
