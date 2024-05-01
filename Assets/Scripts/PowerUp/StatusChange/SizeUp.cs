using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUp : StatusChange
{
    protected override void SetStatus()
    {
        name = "Size Up";
        description = "プレイヤーを大きくする";
        iconPath = "SizeUp";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        float size = StatusManager.instance.PLAYER_SIZE;
        StatusManager.instance.ChangePlayerSize(size * 1.2f);
    }
}
