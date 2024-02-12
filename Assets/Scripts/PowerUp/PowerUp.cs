using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    public new string name { get; protected set; }
    public string description { get; protected set; }
    public string iconPath { get; protected set; }

    protected virtual void SetStatus()
    {
    }

    void Awake()
    {
        SetStatus();
    }

}
