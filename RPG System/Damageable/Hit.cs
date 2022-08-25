namespace RPG.Damageable;

public class Hit {
    public Hit(IDamageable target, DamageContainer damage) {
        Target = target;
        var resistance = target.GetResistance();
        TotalDamage = damage.CalculateTotalDamage(resistance);
    }

    public IDamageable Target { get; init; }
    public float TotalDamage { get; init; }
}

// public class Hit {
//     public Hit(IDamageable target, float totalDamage) {
//         Target = target;
//         TotalDamage = totalDamage;
//     }

//     public IDamageable Target { get; init; }
//     public float TotalDamage { get; init; }
// }