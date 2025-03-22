using System.Xml.Linq;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] protected Weapon activeweapon;
    [SerializeField] protected ArmorType armorType;

    public Weapon ActiveWeapon => activeweapon;
    public ArmorType Armor => armorType;

    public virtual int Attack()
    {
        return activeweapon.GetDamage();
    }

    public virtual void GetHit(int damage)
    {
        health -= damage;
        Debug.Log(name + " current health: " + health);
    }

    public void GetHit(Weapon weapon)
    {
        int baseDamage = weapon.GetDamage();
        int finalDamage = ModifyDamage(baseDamage, weapon.DamageType, armorType);
        health -= finalDamage;

        Debug.Log("Got hit by: " + weapon.name);
        Debug.Log(name + " current health: " + health);
    }

    protected int ModifyDamage(int damage, DamageType dmgType, ArmorType armor)
    {
        float multiplier = 1f;

        if (armor == ArmorType.Light && dmgType == DamageType.Piercing)
            multiplier = 1.5f;

        if (armor == ArmorType.Heavy && dmgType == DamageType.Magic)
            multiplier = 1.5f;

        if (armor == ArmorType.MagicResist && dmgType == DamageType.Magic)
            multiplier = 0.5f;

        if (armor == ArmorType.Medium && dmgType == DamageType.Normal)
            multiplier = 1.2f;

        if (armor == ArmorType.Heavy && dmgType == DamageType.Piercing)
            multiplier = 0.8f;

        return Mathf.CeilToInt(damage * multiplier);
    }

    public int Health => health;
}
