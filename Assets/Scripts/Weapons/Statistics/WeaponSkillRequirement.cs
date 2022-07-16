using Assets.Scripts.CharacterCreation.Skills;
namespace Assets.Scripts.Weapons.Statistics
{
    public class WeaponSkillRequirement
    {
        public ISkill Skill { get; set; }
        public int Amount { get; set; }
    }
}