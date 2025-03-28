using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] internal int aggresion = 10;

    public override int Attack()
    {
        int damage = ActiveWeapon.GetDamage();
        ActiveWeapon.ApplyEffect(GameObject.FindWithTag("Player").GetComponent<Player>());
        return damage;
    }
}
