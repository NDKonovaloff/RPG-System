using RPG.Character;
using RPG.Classes;
using RPG.Damageable;
using RPG.EquipRequirement;
using RPG.Weapons;

var builder = new WeaponBuilder();

var characterPool = new List<Character>() {
    new Character("Ричард Львиное Сердце", new(50f), new(10f), new(){ Strength = 5, Dexterity = 3 }, new Warrior()),
    new Character("Лэйтран", new(30f), new(10f), new(){ Strength = 3, Dexterity = 4, Intelligence = 2}, new Ranger()),
    new Character("Бардок Малдун", new(20f), new(50f), new(){ Intelligence = 5, Dexterity = 2 }, new Mage()),
};

var weaponPool = new List<Weapon>() {
    // Оружие ближнего боя
    builder
        .SetName("Длинный меч")
        .SetWeaponType(WeaponType.Melee)
        .AddDamage(new RegularDamage(10f)).AddDamage(new SlashDamage(20f))
        .AddEquipRequirement(new StrengthRequirement(10f))
        .BuildAndClear(),
    builder
        .SetName("Короткий меч")
        .SetWeaponType(WeaponType.Melee)
        .AddDamage(new RegularDamage(7f)).AddDamage(new SlashDamage(15f))
        .AddEquipRequirement(new StrengthRequirement(3f))
        .BuildAndClear(),
    builder
        .SetName("Кинжал")
        .SetWeaponType(WeaponType.Melee)
        .AddDamage(new RegularDamage(3f)).AddDamage(new SlashDamage(5f))
        .AddEquipRequirement(new StrengthRequirement(1f))
        .BuildAndClear(),
    // Стрелковое оружие
    builder
        .SetName("Лук")
        .SetWeaponType(WeaponType.Range)
        .AddDamage(new RegularDamage(10f)).AddDamage(new PierceDamage(10f))
        .AddEquipRequirement(new DexterityRequirement(3f))
        .BuildAndClear(),
    builder
        .SetName("Арбалет")
        .SetWeaponType(WeaponType.Range)
        .AddDamage(new RegularDamage(10f)).AddDamage(new PierceDamage(20f))
        .AddEquipRequirement(new DexterityRequirement(4f))
        .BuildAndClear(),
    builder
        .SetName("Мушкет")
        .SetWeaponType(WeaponType.Range)
        .AddDamage(new RegularDamage(30f)).AddDamage(new PierceDamage(30f))
        .AddEquipRequirement(new DexterityRequirement(2f))
        .BuildAndClear(),
    // Магические предметы
    builder
        .SetName("Посох")
        .SetWeaponType(WeaponType.Magic)
        .AddDamage(new RegularDamage(10f)).AddDamage(new MagicDamage(30f))
        .AddEquipRequirement(new IntelligenceRequirement(5f))
        .BuildAndClear(),
    builder
        .SetName("Магическая книга")
        .SetWeaponType(WeaponType.Magic)
        .AddDamage(new RegularDamage(3f)).AddDamage(new MagicDamage(20f))
        .AddEquipRequirement(new IntelligenceRequirement(4f))
        .BuildAndClear(),
    builder
        .SetName("Магический символ")
        .SetWeaponType(WeaponType.Magic)
        .AddDamage(new RegularDamage(1f)).AddDamage(new MagicDamage(20f))
        .AddEquipRequirement(new IntelligenceRequirement(3f))
        .BuildAndClear(),
};
