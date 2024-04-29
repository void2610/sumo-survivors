using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public float PLAYER_WEIGHT { get; private set; } = 1.0f;
    public float PLAYER_SPEED { get; private set; } = 10.0f;
    public float EXP_MULTIPLIER { get; private set; } = 1.0f;
    public float ENEMY_SPAWN_RATE { get; private set; } = 1.0f;

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
