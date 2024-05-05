using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombThrower : Summon
{
    private GameObject bomb;
    protected override void SetStatus()
    {
        name = "Bomb Thrower";
        description = "定期的に爆弾を出現させる";
        iconPath = "BombThrower";
        interval = 5;
        bomb = Resources.Load<GameObject>("Prefabs/Object/Bomb");
    }


    public override void SummonObject()
    {
        base.SummonObject();
        Debug.Log(bomb.name + "を召喚しました");
        Vector3 p = GameObject.Find("Player").transform.position;
        Instantiate(bomb, p + Vector3.up * 2, Quaternion.identity);
    }
}
