using RPG.EquipRequirement;

namespace RPG.Weapons;

public class WeaponBuilder {
    private string? _weaponName = null;
    private float _damageValue = 1f;
    private WeaponType _weaponType = default;
    private List<IEquipRequirement> _equipRequirements = new();

    public WeaponBuilder() { }

    public WeaponBuilder(string weaponName, float damageValue, WeaponType weaponType) {
        _weaponName = weaponName;
        _damageValue = damageValue;
        _weaponType = weaponType;
    }

    public WeaponBuilder SetName(string weaponName) {
        _weaponName = weaponName;
        return this;
    }

    public WeaponBuilder SetDamageValue(float damageValue) {
        if (damageValue <= 0f) {
            throw new ArgumentException("Урон оружия должен быть больше 0!");
        }

        _damageValue = damageValue;
        return this;
    }

    public WeaponBuilder SetWeaponType(WeaponType weaponType) {
        _weaponType = weaponType;
        return this;
    }

    public WeaponBuilder AddEquipRequirement(IEquipRequirement equipRequirement) {
        _equipRequirements.Add(equipRequirement);
        return this;
    }

    public WeaponBuilder Clear() {
        _weaponName = null;
        _damageValue = 0;
        _weaponType = default;
        _equipRequirements.Clear();

        return this;
    }

    public Weapon Build() {
        if (_weaponName is null) {
            throw new ArgumentNullException("Оружие должно быть названо!");
        }
        if (_weaponType is default(WeaponType)) {
            throw new ArgumentNullException("Оружию должен быть назначен тип!");
        }
        if (_equipRequirements.Count < 1) {
            throw new ArgumentNullException("Оружие должно содержать хотя бы одно ограничение!");
        }

        IEquipRequirement requirements;
        if (_equipRequirements.Count > 1) {
            requirements = _equipRequirements[0];
        }
        else {
            requirements = new EquipRequirementsContainer(_equipRequirements);
        }
        
        return new(_weaponName, _damageValue, _weaponType, requirements);
    }

    public Weapon BuildAndClear() {
        var weapon = Build();
        Clear();
        return weapon;
    }
}
