using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    protected override void SetStatus()
    {
        WEIGHT = 1.0f;
        ATTACK_POWER = 1.0f;
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
