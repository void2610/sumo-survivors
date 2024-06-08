using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garlic : Summon
{
    private GameObject g;
    private float power = 10;
    private float radius = 3;
    private float time = 3;
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Anti-Geavity Field";
        description = "反重力フィールドを出現させる";
        iconPath = "AntiGeavityField";
        interval = 15.0f;
        g = Resources.Load<GameObject>("Prefabs/Object/AntigravityField");
    }

    public override void LevelUp()
    {
        base.LevelUp();
        power += 5;
        radius += 1;
        time += 0.5f;
        interval -= 1.0f;
    }

    public override void SummonObject()
    {
        base.SummonObject();
        GameObject go = Instantiate(g, GameObject.Find("Player").transform.position, Quaternion.identity);
        go.GetComponent<AntigravityFieldObj>().Init(time, power, radius);
    }

}
