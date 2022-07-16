using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CharacterCreation.Skills
{
    public interface ISkill : IComparable<ISkill>
    {
        public int MaxValue { get; set; }
        public int CurrentValue { get; set; }
        public new int CompareTo(ISkill other);
    }
}
