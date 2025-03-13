using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;


public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] private Weapon activeweapon;

    public Weapon ActiveWeapon
    {
        get { return activeweapon; }
    }

    public virtual int Attack()
    {
        Debug.Log("attacking!");
        return activeweapon.GetDamage();
    }
    public void GetHit(int damage)
    {
        health -= damage;
        Debug.Log(name +"current health:" + health);
    }

    public void GetHit(Weapon weapon)
    {
        health -= weapon.GetDamage();
        Debug.Log("Got hit by: " + weapon.name);
        Debug.Log(name + "current health:" + health);
    }
}
