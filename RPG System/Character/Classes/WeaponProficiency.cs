using RPG.Weapons;

namespace RPG.Classes;
public class WeaponProficiency {
    private WeaponType _weaponType;

    public WeaponProficiency(WeaponType weaponType) {
        _weaponType = weaponType;
    }

    public bool Check(WeaponType type) => type == _weaponType;
}