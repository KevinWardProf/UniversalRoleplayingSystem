using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The interface IComparable is used here so that sorting algorithims can actually determine how to sort instances of this class.
/// Use of the interface IComparer is an external object which determines osrting externally to the object type.
/// </summary>
public class CharacterAttributes /*: IComparable<CharacterStatistics>*/
{
    public int Vitality { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Endurance { get; set; }
    public int Agility { get; set; }
    public int Perception { get; set; }
    public int Intelligence { get; set; }
    public int Charisma { get; set; }
    public int Faith { get; set; }
    public int Luck { get; set; }
    public int Willpower { get; set; }




    //public int CompareTo(CharacterStatistics other) 
    //{
    //    return (other != null) ? 1 : -1;
    //}
}
