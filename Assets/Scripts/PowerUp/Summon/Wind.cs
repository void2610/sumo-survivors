using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : Summon
{
    private GameObject wind;
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Wind";
        description = "定期的に風を発生させる";
        iconPath = "Wind";
        interval = 15;
    }

    public override void StartSummon()
    {
        base.StartSummon();
        wind = Resources.Load<GameObject>("Prefabs/Object/Wind");
    }


    public override void SummonObject()
    {
        base.SummonObject();
        Instantiate(wind, new Vector3(20, 3, 0), Quaternion.identity);
    }
}
