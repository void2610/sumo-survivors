using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChange : PowerUp
{
    public virtual void ChangeStatus()
    {
    }

    public override void LevelUp()
    {
        base.LevelUp();
        ChangeStatus();
        Debug.Log(GetType().Name + " " + "Level: " + level);
    }
}
