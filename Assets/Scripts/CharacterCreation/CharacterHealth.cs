using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CharacterCreation
{
    /// <summary>
    /// Character total health should be dependent on CharacterAttributes. A base amount of 100 + (Vitality + 20). This value is then distributed equally
    /// among each body part.
    /// </summary>
    internal sealed class CharacterHealth
    {
        public int TotalHealth { get; set; }
        public int CurrentHealth 
        {
            get { return (HeadHealth + TorsoHealth + LeftArmHealth + RightArmHealth + LeftLegHealth + RightLegHealth) / TotalHealth; }
            set { CurrentHealth = value; }
        }
        public int HeadHealth { get; set; }
        public int TorsoHealth { get; set; }
        public int LeftArmHealth { get; set; }
        public int RightArmHealth { get; set; }
        public int LeftLegHealth { get; set; }
        public int RightLegHealth { get; set; }
        public  int HeadGib { get; set; }
        public int TorsoArmGib { get; set; }
        public int LeftArmGib { get; set; }
        public int RightArmGib { get; set; }
        public int LeftLegGib { get; set; }
        public int RightLegGib { get; set; }

    }
}
