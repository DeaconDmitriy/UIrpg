using UnityEngine;

public class Mage : Enemy
{
    public override int Attack()
    {
        int damage = ActiveWeapon.GetDamage();
        ActiveWeapon.ApplyEffect(GameObject.FindWithTag("Player").GetComponent<Player>());
        return damage;
    }
}
