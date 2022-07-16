using Assets.Scripts.CharacterCreation;

internal sealed class CharacterDerivedStatistics
{
    public CharacterHealth Health { get; set; } //hit points character has, when 0 character dies
    public CharacterStamina Stamina { get; set; } //
    public float EquipLoad { get; set; }
    public CharacterNeeds Needs;
    //Companion Nerve
    //Critical Chance
    //public CharacterDefense defense;
    //Damage Threshold
    //Physical
    //blunt
    //slash
    //pierce
    //Special
    //Magic
    //Flame
    //Lighting
    public CharacterResistances CharacterResistances {get; set;}
    //public CharacterAttack attack;
        //Base
            //Melee Dam
            //Unarmed Dam
        //Physical
            //blunt
            //slash
            //pierce
        //Special
            //Magic
            //Flame
            //Lighting
}
