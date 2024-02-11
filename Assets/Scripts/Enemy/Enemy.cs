using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    private float MAX_HP;
    private float ATTACK_POWER;
    private float SPEED;
    private float hp;

    private GameObject player;


    public void AddDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    protected void SetStatus(float maxHp, float attackPower, float speed)
    {
        MAX_HP = maxHp;
        ATTACK_POWER = attackPower;
        SPEED = speed;
    }

    public int GetKillScore()
    {
        return Mathf.FloorToInt(MAX_HP);
    }

    protected void MoveToPlayer()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        this.transform.position += direction.normalized * SPEED * Time.deltaTime;
    }

    protected void Awake()
    {
        hp = MAX_HP;
    }

    protected void Start()
    {
        player = GameObject.Find("Player");
    }

    protected void Update()
    {
        MoveToPlayer();
    }
}
