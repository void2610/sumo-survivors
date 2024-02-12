using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    public static ExpManager instance;
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

    private int exp = 0;
    private int level = 1;
    private int[] levelUpExp = new int[] { 1, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 };
    public void AddExp(int addExp)
    {
        exp += addExp;
        if (level >= levelUpExp.Length)
        {
            return;
        }
        if (exp >= levelUpExp[level - 1])
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        exp -= levelUpExp[level - 1];
        level++;

        PowerUpManager.instance.RollPowerUp();
        Time.timeScale = 0;
    }

    public void ResetExp()
    {
        exp = 0;
        level = 1;
    }

    public int GetLevel()
    {
        return level;
    }

    public string GetUIString()
    {
        if (level >= levelUpExp.Length)
        {
            return "EXP: " + exp + " / MAX";
        }
        else
        {
            return "EXP: " + exp + "/" + levelUpExp[level - 1];
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
