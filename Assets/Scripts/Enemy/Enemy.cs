using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float WEIGHT;
    protected float ATTACK_POWER;
    protected float SPEED;

    protected GameObject player;

    protected virtual void SetStatus()
    {
    }

    public int GetKillScore()
    {
        return Mathf.FloorToInt(WEIGHT * ATTACK_POWER * SPEED);
    }

    protected void MoveToPlayer()
    {
        if (player == null)
        {
            return;
        }
        Vector3 direction = player.transform.position - this.transform.position;
        this.transform.position += direction.normalized * SPEED * Time.deltaTime;
    }

    protected void Awake()
    {
        SetStatus();
    }

    protected void Start()
    {
        player = GameObject.Find("Player");
    }

    protected void FixedUpdate()
    {
        MoveToPlayer();
    }
}
