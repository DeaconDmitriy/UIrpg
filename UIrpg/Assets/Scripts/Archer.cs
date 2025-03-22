using UnityEngine;

public class Archer : Enemy
{
    public override int Attack()
    {
        int damage = ActiveWeapon.GetDamage();
        ActiveWeapon.ApplyEffect(GameObject.FindWithTag("Player").GetComponent<Player>());
        return damage;
    }
}
