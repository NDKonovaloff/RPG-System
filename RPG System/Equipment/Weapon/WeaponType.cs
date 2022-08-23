namespace RPG.Weapons;

public enum WeaponType {
    Melee = 1,
    Range = 2,
    Magic = 3
}

//abstract record WeaponType(string Name) {
//    public record Melee() : WeaponType("Melee");
//    public record Range() : WeaponType("Range");
//    public record Magic() : WeaponType("Magic");
//}

//record WeaponType {

//    public static WeaponType Melee = new WeaponType("Оружие ближнего боя");
//    public static WeaponType Range = new WeaponType("Оружие ближнего боя");
//    public static WeaponType Magic = new WeaponType("Оружие ближнего боя");

//    public string Name { get; init; }

//    private WeaponType(string name) { Name = name; }
//}