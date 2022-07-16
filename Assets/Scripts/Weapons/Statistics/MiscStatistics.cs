using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Weapons.Statistics
{
    public class MiscStatistics
    {
        public float Weight { get; set; }
        public int Value { get; set; }
        public int Condition { get; set; }
        public List<string> RepairTypes { get; set; }
        public string FormID { get; set; }
    }
}
