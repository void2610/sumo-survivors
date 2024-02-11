using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
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

    private int score = 0;
    public void AddScore(int addScore)
    {
        score += addScore;
    }

    public int GetScore()
    {
        return score;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
