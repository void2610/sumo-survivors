using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public float PLAYER_WEIGHT { get; private set; }
    public float PLAYER_SPEED { get; private set; }
    public float PLAYER_SIZE;
    public float EXP_MULTIPLIER { get; private set; }
    public float ENEMY_SPAWN_RATE { get; private set; }

    public void ResetStatus()
    {
        PLAYER_WEIGHT = 1.0f;
        PLAYER_SPEED = 10.0f;
        PLAYER_SIZE = 1.0f;
        EXP_MULTIPLIER = 1.0f;
        ENEMY_SPAWN_RATE = 1.0f;
    }

    public void ChangePlayerWeight(float value)
    {
        PLAYER_WEIGHT = value;
        GameObject player = GameObject.Find("Player");
        player.GetComponent<Rigidbody>().mass = PLAYER_WEIGHT;
    }

    public void ChangePlayerSpeed(float value)
    {
        PLAYER_SPEED = value;
    }

    public void ChangePlayerSize(float value)
    {
        PLAYER_SIZE = value;
        GameObject player = GameObject.Find("Player");
        player.transform.localScale = new Vector3(PLAYER_SIZE, PLAYER_SIZE, PLAYER_SIZE);
    }


    public static StatusManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            ResetStatus();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
