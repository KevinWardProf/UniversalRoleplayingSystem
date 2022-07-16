using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Weapons.Statistics
{
    public class AttackStatistics
    {
        public List<WeaponDamage> DamagePerAttack { get; set; }
        //public List<WeaponDamage> DamagePerProjectile { get; set; } //Irrelevant to Melee, maybe should remove, only for shotguns
        public float DamagePerSecond { get; set; } //Calculate this as DamagePerAttack/AttacksPerSec
        public int CriticalDamage { get; set; }
        public float CriticalMultiplier { get; set; }
        public float AttacksPerSec { get; set; }
        public int Projectiles { get; set; } //This number can be used to define colliders for melee/num of arrows/bullets/etc
        public RecoilPercentages RecoilPercentages { get; set; } //Maybe make this affect melee failed strikes
        public int EffectiveRange { get; set; }
    }
}
