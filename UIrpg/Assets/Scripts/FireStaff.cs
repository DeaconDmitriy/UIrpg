using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class FireStaff : Weapon
{
    [SerializeField] private int burnChancePercent = 30;

    public override void ApplyEffect(Character character)
    {
        int roll = Random.Range(0, 100);
        if (roll < burnChancePercent)
        {
            Debug.Log("Burn effect applied to: " + character.name);
            character.GetHit(5);
        }
    }
}
