using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CharacterCreation
{
    /// <summary>
    /// Needs work. These properties don't make sense. Stamina at all times should be (Endurance * 3) + 65.
    /// </summary>
    internal sealed class CharacterStamina
    {
        public int TotalStamina { get; set; }
        public int CurrentStamina
        { 
            get { return (ArmStamina + LegStamina); }
            set { CurrentStamina = value; }
        }
        public int ArmStamina { get; set; }
        public int LegStamina { get; set; }
    }
}
