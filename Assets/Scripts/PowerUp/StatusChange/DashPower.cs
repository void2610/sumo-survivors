using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPower : StatusChange
{
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Dash Power";
        description = "プレイヤーのダッシュの勢いを上げる";
        iconPath = "DashPower";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        StatusManager.instance.DASH_POWER *= 2f;
    }
}
