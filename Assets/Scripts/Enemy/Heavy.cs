using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heavy : Enemy
{
    protected override void SetStatus()
    {
        COLOR = new Color(1.0f, 1.0f, 0.0f, 1.0f);
        WEIGHT = 100.0f;
        SIZE = 1.1f;
        SPEED = 1.0f;
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
