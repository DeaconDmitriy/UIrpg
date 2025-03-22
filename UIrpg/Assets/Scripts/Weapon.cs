using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private int minDamage, maxDamage;
    [SerializeField] protected DamageType damageType = DamageType.Normal;

    public DamageType DamageType => damageType;

    public int GetDamage()
    {
        return Random.Range(minDamage, maxDamage);
    }

    public abstract void ApplyEffect(Character character);
}
