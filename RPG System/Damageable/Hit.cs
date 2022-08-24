namespace RPG.Damageable;

public class Hit {
    public Hit(IDamageable target, float totalDamage) {
        Target = target;
        TotalDamage = totalDamage;
    }

    public IDamageable Target { get; init; }
    public float TotalDamage { get; init; }
}