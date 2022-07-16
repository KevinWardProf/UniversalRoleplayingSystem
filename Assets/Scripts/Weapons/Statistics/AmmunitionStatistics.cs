using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Weapons.Statistics
{
    public class AmmunitionStatistics
    {
        public List<string> AmmunitionTypes { get; set; }
        public int AmmunitionPerShot { get; set; }
        public int AmmunitionCapacity { get; set; }
        public float ReloadTime { get; set; }

    }
}
