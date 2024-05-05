using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGeavityField : Summon
{
    private GameObject agf;
    protected override void SetStatus()
    {
        name = "Anti-Geavity Field";
        description = "反重力フィールドを出現させる";
        iconPath = "AntiGeavityField";
        interval = 15.0f;
        agf = Resources.Load<GameObject>("Prefabs/Object/AntigravityField");
    }


    public override void SummonObject()
    {
        base.SummonObject();
        Instantiate(agf);
    }
}
