using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    public new string name { get; protected set; }
    public string description { get; protected set; }
    public string iconPath { get; protected set; }
    public int level = 0;

    public virtual void SetStatus()
    {
        level = PowerUpManager.instance.powerUpLevelDict[this.GetType()];
    }
}
