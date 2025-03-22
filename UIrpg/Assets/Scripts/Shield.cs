using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private float damageReductionPercent = 0.5f; 
    [SerializeField] private float breakChance = 0.2f; 
    public bool IsActive { get; private set; } = false;
    public bool IsBroken { get; private set; } = false;

    public void Toggle()
    {
        if (IsBroken) return;
        IsActive = !IsActive;
    }

    public int AbsorbDamage(int incomingDamage)
    {
        if (!IsActive || IsBroken) return incomingDamage;

        int reducedDamage = Mathf.CeilToInt(incomingDamage * (1 - damageReductionPercent));

        if (Random.value < breakChance)
        {
            IsBroken = true;
            Debug.Log("Shield has broken!");
        }

        return reducedDamage;
    }
}