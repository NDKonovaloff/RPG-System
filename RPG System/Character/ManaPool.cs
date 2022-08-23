namespace RPG.Character;

public class ManaPool {
    public float MaxValue { get; private set; }
    public float Value { get; private set; }

    public ManaPool(float initialMana = 1f) {
        MaxValue = initialMana;
        Value = initialMana;
    }
}