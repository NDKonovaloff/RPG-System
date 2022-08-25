using RPG.Damageable;
using RPG.EquipRequirement;

namespace RPG.Weapons;

public class WeaponBuilder {
    private string? _weaponName = null;
    private List<IDamage> _damageList = new();
    private WeaponType _weaponType = default;
    private List<IEquipRequirement> _requirementList = new();

    public WeaponBuilder() { }

    public WeaponBuilder SetName(string weaponName) {
        _weaponName = weaponName;
        return this;
    }

    public WeaponBuilder AddDamage(IDamage damage) {
        _damageList.Add(damage);
        return this;
    }

    public WeaponBuilder SetWeaponType(WeaponType weaponType) {
        _weaponType = weaponType;
        return this;
    }

    public WeaponBuilder AddEquipRequirement(IEquipRequirement equipRequirement) {
        _requirementList.Add(equipRequirement);
        return this;
    }

    public WeaponBuilder Clear() {
        _weaponName = null;
        _weaponType = default;

        _damageList.Clear();
        _requirementList.Clear();

        return this;
    }

    public Weapon Build() {
        if (_weaponName is null) {
            throw new ArgumentNullException("Оружие должно быть названо!");
        }
        if (_weaponType is default(WeaponType)) {
            throw new ArgumentNullException("Оружию должен быть назначен тип!");
        }

        var requirements = ChooseRequirementsContainer();
        var damageContainer = new DamageContainer(_damageList);
        return new(_weaponName, damageContainer, _weaponType, requirements);
    }

    public Weapon BuildAndClear() {
        var weapon = Build();
        Clear();
        return weapon;
    }

    private IEquipRequirement? ChooseRequirementsContainer() => _requirementList.Count switch {
        0 => null,
        1 => _requirementList[0],
        _ => new EquipRequirements(_requirementList)
    };
}
