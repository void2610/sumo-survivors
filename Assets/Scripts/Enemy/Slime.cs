using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    new void Awake()
    {
        base.Awake();
        SetStatus(1, 1, 1);
    }

    new void Start()
    {
        base.Start();
    }

    new void Update()
    {
        base.Update();
    }
}
