using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Enemy
{
    [SerializeField] private int agressionGain = 5;

    public override int Attack()
    {
        aggresion += agressionGain;
        int baseDamage = aggresion / 10;
        ActiveWeapon.ApplyEffect(GameObject.FindWithTag("Player").GetComponent<Player>());
        return baseDamage + ActiveWeapon.GetDamage();
    }
}
