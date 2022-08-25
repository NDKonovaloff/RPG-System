namespace RPG.Damageable;

public class DamageContainer {
    public DamageContainer(List<IDamage> damages) {
        Damages = damages.ToArray();
    }

    public DamageContainer(IDamage[] damages) {
        Damages = damages;
    }

    public IDamage[] Damages { get; init; }

    public float CalculateTotalDamage(ResistanceStats resistance) {
        float totalDamage = 0f;
        foreach(var damage in Damages) {
            totalDamage += damage.ReduceByResistance(resistance);
        }
        return totalDamage;
    } 
}