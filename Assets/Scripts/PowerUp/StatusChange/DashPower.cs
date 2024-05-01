using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPower : StatusChange
{
    protected override void SetStatus()
    {
        name = "Dash Power";
        description = "プレイヤーのダッシュの勢いを上げる";
        iconPath = "DashPower";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        StatusManager.instance.DASH_POWER *= 1.4f;
    }
}
