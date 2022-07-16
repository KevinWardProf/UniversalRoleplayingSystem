using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CharacterCreation.Perks
{
    interface IPerk
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //Conditions need to be a list of base value checks on the attributes and skills.
    }
}
