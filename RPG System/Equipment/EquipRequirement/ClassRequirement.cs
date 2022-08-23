using RPG.Character;
using RPG.Classes;

namespace RPG.EquipRequirement;

class ClassRequirement<TClass> : IEquipRequirement where TClass : ICharacterClass {
    public bool Check(ICharacter target) => target.Class is TClass;

    public string GetRequirementFailureMessage(ICharacter character) =>
        $"Персонаж должен быть класса {typeof(TClass)}.";
}
