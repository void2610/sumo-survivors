using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    void Awake()
    {
        base.Awake();
        SetStatus(1, 1, 1);
    }

    void Start()
    {
        base.Start();
    }

    void Update()
    {
        base.Update();
    }
}
