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


    protected override void ChangeStatus()
    {
        StatusManager.instance.PLAYER_WEIGHT += 0.5f;
    }
}
