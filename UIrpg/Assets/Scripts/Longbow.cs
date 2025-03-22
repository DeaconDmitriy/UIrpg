using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Longbow : Weapon
{
    [SerializeField] private float critChance = 0.25f;
    [SerializeField] private float critMultiplier = 1.5f;

    public override void ApplyEffect(Character character)
    {
        bool isCrit = Random.value < critChance;
        if (isCrit)
        {
            int extraDamage = Mathf.CeilToInt(GetDamage() * (critMultiplier - 1));
            character.GetHit(extraDamage);
            Debug.Log("Critical arrow hit! Extra damage: " + extraDamage);
        }
    }
}
