using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    protected override void SetStatus()
    {
        COLOR = new Color(0.0f, 0.6f, 1.0f, 1.0f);
        WEIGHT = 1.0f;
        SIZE = 1.0f;
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
