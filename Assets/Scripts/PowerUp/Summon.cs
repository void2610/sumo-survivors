using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : PowerUp
{
    public float interval { get; protected set; }

    public virtual void SummonObject()
    {

    }

    public virtual void StartSummon()
    {
        InvokeRepeating("SummonObject", 0, interval);
    }

    public virtual void StopSummon()
    {
        CancelInvoke("SummonObject");
    }

    public override void LevelUp()
    {
        base.LevelUp();
        StopSummon();
        StartSummon();
        Debug.Log(GetType().Name + " " + "Level: " + level);
    }
}
