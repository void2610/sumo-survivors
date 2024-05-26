using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast : Enemy
{
    protected override void SetStatus()
    {
        COLOR = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        WEIGHT = 0.5f;
        SIZE = 0.5f;
        SPEED = 10.0f;
    }

    new void Awake()
    {
        base.Awake();
    }

    protected override void MoveToPlayer()
    {
        if (player == null)
        {
            return;
        }
        Vector3 direction = player.transform.position - this.transform.position + new Vector3(0.0f, 0.2f, 0.0f);
        this.transform.position += direction.normalized * SPEED * Time.deltaTime;
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
