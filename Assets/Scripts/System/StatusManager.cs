using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public float PLAYER_WEIGHT = 1.0f;
    public float PLAYER_SPEED = 1.0f;
    public float EXP_MULTIPLIER = 1.0f;
    public float ENEMY_SPAWN_RATE = 1.0f;


    public static StatusManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
