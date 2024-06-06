using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Summon
{
    private GameObject bomb;
    private float power = 100;
    private float radius = 2;
    private float time = 3f;
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Bomb Thrower";
        description = "定期的に爆弾を出現させる";
        iconPath = "BombThrower";
        interval = 10;
        bomb = Resources.Load<GameObject>("Prefabs/Object/Bomb");
    }

    public override void LevelUp()
    {
        base.LevelUp();
        power += 100;
        radius += 1;
        time -= 0.2f;
        interval -= 1.0f;
    }

    public override void SummonObject()
    {
        base.SummonObject();
        Vector3 p = GameObject.Find("Player").transform.position;
        GameObject b = Instantiate(bomb, p + Vector3.up * 2, Quaternion.identity);
        b.GetComponent<BombObj>().Init(power, radius, time);
    }
}
