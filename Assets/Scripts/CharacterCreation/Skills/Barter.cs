using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CharacterCreation.Skills
{
    class Barter : ISkill
    {
        public int MaxValue { get; set; }
        public int CurrentValue { get; set; }

        public int CompareTo(ISkill other)
        {
            //Return a neg val, this is less than the other, return 0, this is equal to the other, return pos val, this is greater than the other
            if (this.CurrentValue > other.CurrentValue)
            {
                return 1;
            }
            else if (this.CurrentValue == other.CurrentValue)
            {
                return 0;
            }
            else //(this.currentValue < other.currentValue)
            {
                return -1;
            }

        }
    }
}
