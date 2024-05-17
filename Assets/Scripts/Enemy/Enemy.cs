using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Color COLOR;
    protected float WEIGHT;
    protected float SIZE;
    protected float SPEED;
    protected GameObject player;

    protected virtual void SetStatus()
    {
    }

    public int GetKillScore()
    {
        return Mathf.FloorToInt(WEIGHT * SIZE * SPEED);
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
        this.transform.localScale = new Vector3(SIZE, SIZE, SIZE);
        this.GetComponent<Rigidbody>().mass = WEIGHT;
        this.GetComponent<MeshRenderer>().material.color = COLOR;
    }

    protected void FixedUpdate()
    {
        MoveToPlayer();
    }
}
