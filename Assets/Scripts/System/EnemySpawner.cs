using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemyPrefabs = new List<GameObject>();
    private Vector3[] spawnRange = new Vector3[2];

    public void SpawnEnemy(int enemyIndex, int n = 1)
    {
        if (enemyIndex < 0 || enemyIndex >= enemyPrefabs.Count) return;

        for (int i = 0; i < n; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(spawnRange[0].x, spawnRange[1].x), 1, Random.Range(spawnRange[0].z, spawnRange[1].z));
            GameObject enemy = Instantiate(enemyPrefabs[enemyIndex], spawnPosition, Quaternion.identity);
        }
    }

    void Start()
    {
        GameObject field = GameObject.Find("Floor");
        Vector3 floorSize = field.GetComponent<Renderer>().bounds.size;

        spawnRange[0] = field.GetComponent<Transform>().position - floorSize / 2f;
        spawnRange[1] = field.GetComponent<Transform>().position + floorSize / 2f;
    }
}
