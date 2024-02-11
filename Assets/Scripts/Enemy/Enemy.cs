using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float WEIGHT;
    private float ATTACK_POWER;
    private float SPEED;

    private GameObject player;

    protected void SetStatus(float weight, float attackPower, float speed)
    {
        WEIGHT = weight;
        ATTACK_POWER = attackPower;
        SPEED = speed;
    }

    public int GetKillScore()
    {
        return Mathf.FloorToInt(WEIGHT * ATTACK_POWER * SPEED);
    }

    protected void MoveToPlayer()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        this.transform.position += direction.normalized * SPEED * Time.deltaTime;
    }

    protected void Awake()
    {
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
