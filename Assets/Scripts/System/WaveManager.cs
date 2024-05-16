using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    // とりあえずレベルで制御
    float spawnNum = 1.0f;
    EnemySpawner spawner;
    private float timer = 0.0f;
    void Start()
    {
        spawner = GameObject.Find("GameManager").GetComponent<EnemySpawner>();
        timer = 0.0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        spawnNum = 0.5f * ExpManager.instance.GetLevel() + 1.5f * StatusManager.instance.ENEMY_SPAWN_RATE;
    }

    void FixedUpdate()
    {
        if (Time.frameCount % 60 == 0)
        {
            for (int i = 0; i < Mathf.Floor(spawnNum); i++)
            {
                spawner.SpawnEnemy(0);
                spawner.SpawnEnemy(1);
                spawner.SpawnEnemy(2);
            }
            if (0.5f > spawnNum - Mathf.Floor(spawnNum))
            {
                spawner.SpawnEnemy(0);
            }
        }
    }
}
