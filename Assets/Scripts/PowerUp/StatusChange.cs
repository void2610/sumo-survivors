using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChange : PowerUp
{
    public virtual void ChangeStatus()
    {
        Debug.Log(this.name);
    }
}
