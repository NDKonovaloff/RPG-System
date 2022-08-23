namespace RPG.Character;

public class Health {
    public float MaxValue { get; private set; }
    public float Value { get; private set; }

    public Health(float initialHealth = 1f) {
        MaxValue = initialHealth;
        Value = initialHealth;
    }

    public bool IsDead => Value <= 0f;

    public override string ToString() => $"{Value}/{MaxValue}";
}
