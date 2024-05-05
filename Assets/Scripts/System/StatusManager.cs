using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public float PLAYER_WEIGHT;
    public float PLAYER_SPEED;
    public float PLAYER_SIZE;
    public float DASH_POWER;
    public float DASH_COOLTIME;
    public float EXP_MULTIPLIER;
    public float ENEMY_SPAWN_RATE;
    public float STAGE_SIZE;

    public void ResetStatus()
    {
        PLAYER_WEIGHT = 1.0f;
        PLAYER_SPEED = 10.0f;
        PLAYER_SIZE = 1.0f;
        DASH_POWER = 1.0f;
        DASH_COOLTIME = 2.0f;
        EXP_MULTIPLIER = 1.0f;
        ENEMY_SPAWN_RATE = 1.0f;
        STAGE_SIZE = 1.0f;
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
