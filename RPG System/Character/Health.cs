using System;

namespace RPG.Character;

public class Health {
    public float MaxValue { get; private set; }
    public float Value { get; private set; }

    public Health(float initialHealth = 1f) {
        MaxValue = initialHealth;
        Value = initialHealth;
    }

    public void Reduce(float value) {
        const float minValue = 0f;
        Value = Math.Clamp(Value - value, minValue, MaxValue);
    }

    public void Increase(float value) {
        const float minValue = 0f;
        Value = Math.Clamp(Value + value, minValue, MaxValue);
    }

    public bool IsDead => Value <= 0f;

    public override string ToString() => $"{Value}/{MaxValue}";
}
