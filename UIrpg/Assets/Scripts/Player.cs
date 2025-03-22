using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private string charName;
    [SerializeField] private Shield shield;

    private int level = 1;
    private int currentXP = 0;
    private int xpToNextLevel = 100;

    private int buffTurns = 0;
    private float damageBuffMultiplier = 5f;

    public string CharName => charName;
    public Shield Shield => shield;
    public int Level => level;
    public int CurrentXP => currentXP;
    public int XPToNextLevel => xpToNextLevel;

    public void SetWeapon(Weapon newWeapon)
    {
        activeweapon = newWeapon;
    }

    public override void GetHit(int damage)
    {
        if (shield != null && shield.IsActive && !shield.IsBroken)
        {
            damage = shield.AbsorbDamage(damage);
        }

        base.GetHit(damage);
    }

    public override int Attack()
    {
        int damage = base.Attack();

        if (buffTurns > 0)
        {
            damage = Mathf.CeilToInt(damage * damageBuffMultiplier);
            buffTurns--;
        }

        return damage;
    }

    public void AddXP(int xp)
    {
        currentXP += xp;

        if (currentXP >= xpToNextLevel)
        {
            currentXP -= xpToNextLevel;
            level++;
            health += 10;
            xpToNextLevel += 50;
        }
    }

    public void CastBuff()
    {
        buffTurns = 3;
    }

    public void CastHeal()
    {
        health += 20;
        if (health > 100)
            health = 100;
    }
}
