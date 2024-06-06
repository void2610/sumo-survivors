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
    private int[] levelUpExpList = { 1, 5, 10, 20, 30, 50, 70, 100, 150, 250, 500, 1000, 1500, 2000, 2500 };
    public void AddExp(int addExp)
    {
        exp += addExp;
        if (level >= levelUpExpList.Length)
        {
            return;
        }

        if (exp >= levelUpExpList[level - 1])
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        exp = 0;
        level++;

        PowerUpManager.instance.RollPowerUp();
        GameManager.instance.ChangeGameState(GameState.LevelUp);
        UIManager.instance.ChangeActiveUI(GameState.LevelUp);
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
        if (level >= levelUpExpList.Length)
        {
            return "EXP: MAX";
        }
        return "EXP: " + exp + "/" + levelUpExpList[level - 1];
    }
}
