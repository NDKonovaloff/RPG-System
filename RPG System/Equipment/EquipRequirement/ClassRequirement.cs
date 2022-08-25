using RPG.Character;
using RPG.Classes;

namespace RPG.EquipRequirement;

class ClassRequirement<TClass> : IEquipRequirement where TClass : ICharacterClass {
    public string RequirementFailureMessage => $"Персонаж должен быть класса {typeof(TClass)}.";
    public bool Check(ICharacter target) => target.Class is TClass;
}
