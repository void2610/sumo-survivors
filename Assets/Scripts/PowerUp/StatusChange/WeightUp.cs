using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightUp : StatusChange
{
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Weight Up";
        description = "プレイヤーの重さを上げる";
        iconPath = "WeightUp";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        StatusManager.instance.PLAYER_WEIGHT *= 2f;
        GameObject.Find("Player").GetComponent<Rigidbody>().mass = StatusManager.instance.PLAYER_WEIGHT;
    }
}
