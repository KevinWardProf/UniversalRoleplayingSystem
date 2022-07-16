using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Weapons.Statistics
{
    public class WeaponRequirements
    {
        public List<WeaponSkillRequirement> Skill { get; set; }
        public AttributeRequirements AttributeRequirement { get; set; }
    }
}
