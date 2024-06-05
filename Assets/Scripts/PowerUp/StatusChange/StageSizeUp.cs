using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSizeUp : StatusChange
{
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Stage Size Up";
        description = "ステージを拡大する";
        iconPath = "StageSizeUp";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        StatusManager.instance.STAGE_SIZE *= 1.3f;
    }
}
