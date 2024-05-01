using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : StatusChange
{
    protected override void SetStatus()
    {
        name = "Speed Up";
        description = "プレイヤーの移動速度を上げる";
        iconPath = "SpeedUp";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        StatusManager.instance.PLAYER_SPEED += 1.0f;
    }
}
