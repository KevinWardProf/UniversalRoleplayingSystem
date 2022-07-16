using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Weapons.Statistics;
public interface IWeapon
{
    //TODO: Guns have projectile and bash attacks, these need representation here as data. Ex: Rifle(RT=Projectile, RB=Bash, LT=Aim, LB=???)
    //TODO: DamagePerAttack = DamagePerProjectile x Projectiles?
    //TODO: Magazines need to be created, with some kind of name, some stats, etc
    //TODO: Line this class up to work with Bows, Crossbows, Melee and Unarmed weapons.

    public WeaponRequirements WeaponRequirements { get; set; }
    public List<WeaponDamage> WeaponDamage { get; set; }
    public AttackStatistics AttackStatistics { get; set; }
    public MiscStatistics MiscStatistics { get; set; }
}
