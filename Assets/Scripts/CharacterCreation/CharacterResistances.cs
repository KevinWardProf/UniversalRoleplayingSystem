using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CharacterCreation
{
    public sealed class CharacterResistances
    {
        public float Radiation { get; set; } //Stat against Radition Poisioning Status Effect
        public float Bleed { get; set; } //Stat against Bleeding Status Effect
        public float Poision { get; set; } //Stat against Poisioned Status Effect
        public float Toxic { get; set; } //Stat against Toxic Status Effect
        public float Curse { get; set; } //Stat against Cursed Status Effect
        public float Paralysis { get; set; } //Stat against Paralyzed Status Effect
        public float Burn { get; set; } //Stat against Burning Status Effect
        public float Freeze { get; set; } //Stat Against Freeze Status Effect
        public float Confusion { get; set; } //Stat against Confused Status Effect
        public float Infatuation { get; set; } //Stat against Infatuated Status Effect
        public float Flinch { get; set; } //Stat against Stagger Status Effect
        public float Traction { get; set; } //Stat against LostBalance Status Effect
    }
}
