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
    private int[] levelUpExpList = { 1, 5, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 120, 140, 160, 180, 200, 220, 240, 260, 280, 300 };
    public void AddExp(int addExp)
    {
        exp += addExp;
        if (exp >= levelUpExpList[level - 1])
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        exp = 0;
        level++;
        Debug.Log("Level Up! Current Level: " + level);

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
        if (level == levelUpExpList.Length)
        {
            return "EXP: / MAX";
        }
        return "EXP: " + exp + "/" + levelUpExpList[level - 1];
    }
}
