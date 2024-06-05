using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUp : StatusChange
{
    public override void SetStatus()
    {
        base.SetStatus();
        name = "Size Up";
        description = "プレイヤーを大きくする";
        iconPath = "SizeUp";
    }


    public override void ChangeStatus()
    {
        base.ChangeStatus();
        StatusManager.instance.PLAYER_SIZE *= 1.5f;
        GameObject.Find("Player").transform.localScale = Vector3.one * StatusManager.instance.PLAYER_SIZE;
    }
}
