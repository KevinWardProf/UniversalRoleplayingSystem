using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CharacterCreation.StatusEffects
{
    interface IStatusEffect
    {
        public string Name { get; set; }
        //Effect should be some kind of effect for the
        //values of attributes, skills, derived stats
        //public IStatusEffect Effect { get; set; }
    }
}
