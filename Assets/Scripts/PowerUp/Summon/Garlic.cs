using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garlic : Summon
{
    private GameObject g;
    private float power = 2;
    private float radius = 3;
    private GarlicObj instance;
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Garlic";
        description = "にんにく、臭い";
        iconPath = "Garlic";
        interval = Mathf.Infinity;
        g = Resources.Load<GameObject>("Prefabs/Object/Garlic");
    }

    public override void LevelUp()
    {
        instance?.DestroyGarlic();
        base.LevelUp();
        power += 1.5f;
        radius += 0.5f;
    }

    public override void SummonObject()
    {
        base.SummonObject();
        Debug.Log("Summon Garlic");
        Transform p = GameObject.Find("Player").transform;
        instance = Instantiate(g, p.position, Quaternion.identity).GetComponent<GarlicObj>();
        instance.Init(power, radius, p);
    }

}
