using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private int spawnNum = 1;
    [SerializeField]
    EnemySpawner spawner;

    void FixedUpdate()
    {
        if (Time.frameCount % 20 == 0)
        {
            for (int i = 0; i < spawnNum; i++)
            {
                spawner.SpawnEnemy(0);
            }
            if (0.5f > spawnNum - Mathf.Floor(spawnNum))
            {
                spawner.SpawnEnemy(0);
            }
        }
    }
}
