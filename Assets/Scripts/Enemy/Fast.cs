using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast : Enemy
{
    protected override void SetStatus()
    {
        WEIGHT = 0.5f;
        SIZE = 0.5f;
        SPEED = 10.0f;
    }

    new void Awake()
    {
        base.Awake();
    }

    new void Start()
    {
        base.Start();
    }

    new void FixedUpdate()
    {
        base.FixedUpdate();
    }
}
