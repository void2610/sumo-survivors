using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : Summon
{
    private float time = 3.0f;
    private float coefficient = 0.1f;
    private float power = 18;
    private GameObject wind;
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Wind";
        description = "定期的に風を発生させる";
        iconPath = "Wind";
        interval = 15;
        wind = Resources.Load<GameObject>("Prefabs/Object/Wind");
    }

    public override void LevelUp()
    {
        base.LevelUp();
        time += 1.0f;
        coefficient += 0.1f;
        power += 1.5f;
        interval -= 1.0f;
    }

    public override void SummonObject()
    {
        base.SummonObject();
        GameObject g = Instantiate(wind, new Vector3(20, 3, 0), Quaternion.identity);
        g.GetComponent<WindObj>().Init(time, coefficient, power);
    }
}
