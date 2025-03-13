using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Enemy
{
    [SerializeField] private int agressionGain = 5;
    // Start is called before the first frame update
    public override int Attack()
    {
        aggresion += agressionGain;
        return aggresion / 10;
    }
}
