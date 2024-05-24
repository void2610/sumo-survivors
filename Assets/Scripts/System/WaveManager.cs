using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private int wave = 0;
    private List<int[]> waveData = new List<int[]>();
    private int[] enemyNum = { 0, 0, 0 };
    EnemySpawner spawner;
    private float timer = 0.0f;
    private int frameCount = 0;

    public int GetWave()
    {
        return wave;
    }


    void Start()
    {
        waveData.Add(new int[] { 1, 0, 0 });
        waveData.Add(new int[] { 1, 0, 0 });
        waveData.Add(new int[] { 1, 0, 0 });
        waveData.Add(new int[] { 0, 1, 0 });
        waveData.Add(new int[] { 0, 1, 0 });
        waveData.Add(new int[] { 0, 0, 1 });
        waveData.Add(new int[] { 0, 0, 1 });
        waveData.Add(new int[] { 1, 1, 0 });
        waveData.Add(new int[] { 1, 1, 0 });
        waveData.Add(new int[] { 1, 0, 1 });
        waveData.Add(new int[] { 1, 0, 1 });
        waveData.Add(new int[] { 1, 1, 1 });
        waveData.Add(new int[] { 1, 1, 1 });
        waveData.Add(new int[] { 1, 1, 1 });
        waveData.Add(new int[] { 2, 2, 2 });
        waveData.Add(new int[] { 2, 2, 2 });
        waveData.Add(new int[] { 2, 2, 2 });
        waveData.Add(new int[] { 2, 2, 2 });
        waveData.Add(new int[] { 3, 3, 3 });
        waveData.Add(new int[] { 3, 3, 3 });
        waveData.Add(new int[] { 3, 3, 3 });
        waveData.Add(new int[] { 3, 3, 3 });
        waveData.Add(new int[] { 4, 4, 4 });
        waveData.Add(new int[] { 4, 4, 4 });
        waveData.Add(new int[] { 5, 5, 5 });

        spawner = GameObject.Find("GameManager").GetComponent<EnemySpawner>();
        timer = 0.0f;
        wave = 0;
        enemyNum[0] += waveData[wave][0];
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 30.0f && wave < waveData.Count - 1)
        {
            wave++;
            enemyNum[0] += waveData[wave][0];
            enemyNum[1] += waveData[wave][1];
            enemyNum[2] += waveData[wave][2];
            timer = 0.0f;
            Debug.Log("Wave " + wave);
        }
    }

    void FixedUpdate()
    {
        frameCount++;
        if (frameCount % 60 == 0)
        {
            spawner.SpawnEnemy(0, enemyNum[0]);
            spawner.SpawnEnemy(1, enemyNum[1]);
            spawner.SpawnEnemy(2, enemyNum[2]);
        }
    }
}
