using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    // とりあえずレベルで制御
    float spawnNum = 1.0f;
    EnemySpawner spawner;
    void Start()
    {
        spawner = GameObject.Find("GameManager").GetComponent<EnemySpawner>();
    }

    void Update()
    {
        spawnNum = 0.5f * ExpManager.instance.GetLevel() + 1.0f * StatusManager.instance.ENEMY_SPAWN_RATE;
    }

    void FixedUpdate()
    {
        if (Time.frameCount % 60 == 0)
        {
            for (int i = 0; i < Mathf.Floor(spawnNum); i++)
            {
                spawner.SpawnEnemy();
            }
            if (0.5f > spawnNum - Mathf.Floor(spawnNum))
            {
                spawner.SpawnEnemy();
            }
        }
    }
}
