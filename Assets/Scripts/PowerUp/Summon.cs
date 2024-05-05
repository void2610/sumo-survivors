using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : PowerUp
{
    public float interval { get; protected set; }
    public float targetObject { get; protected set; }

    public virtual void SummonObject()
    {

    }

    public void StartSummon()
    {
        InvokeRepeating("SummonObject", 0, interval);
    }
}
