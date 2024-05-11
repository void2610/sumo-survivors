using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCycle : StatusChange
{
    protected override void SetStatus()
    {
        name = "Dash Cycle";
        description = "プレイヤーのダッシュのクールタイムを短くする";
        iconPath = "DashCycle";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        StatusManager.instance.DASH_COOLTIME *= 0.5f;
    }
}
