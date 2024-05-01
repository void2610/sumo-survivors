using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightUp : StatusChange
{
    protected override void SetStatus()
    {
        name = "Weight Up";
        description = "プレイヤーの重さを上げる";
        iconPath = "WeightUp";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        float weight = StatusManager.instance.PLAYER_WEIGHT;
        StatusManager.instance.ChangePlayerWeight(weight + 0.5f);
    }
}
