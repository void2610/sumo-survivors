using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : Summon
{
    private GameObject bomb;
    protected override void SetStatus()
    {
        name = "Wind";
        description = "定期的に風を発生させる";
        iconPath = "Wind";
        interval = 15;
        bomb = Resources.Load<GameObject>("Prefabs/Object/Wind");
    }


    public override void SummonObject()
    {
        base.SummonObject();
        Instantiate(bomb, new Vector3(20, 3, 0), Quaternion.identity);
    }
}
