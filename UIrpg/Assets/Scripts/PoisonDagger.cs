using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonDagger : Weapon
{
    public override void ApplyEffect(Character character)
    {
        Debug.Log("Poison effect applied to: " + character.name);
    }
}

