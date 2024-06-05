using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGeavityField : Summon
{
    private GameObject agf;
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Anti-Geavity Field";
        description = "反重力フィールドを出現させる";
        iconPath = "AntiGeavityField";
        interval = 15.0f;
    }

    public override void StartSummon()
    {
        base.StartSummon();
        agf = Resources.Load<GameObject>("Prefabs/Object/AntigravityField");
    }

    public override void SummonObject()
    {
        base.SummonObject();
        Instantiate(agf, GameObject.Find("Player").transform.position, Quaternion.identity);
    }
}
