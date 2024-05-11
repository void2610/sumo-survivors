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
    private int levelUpExp = 1;
    public void AddExp(int addExp)
    {
        exp += addExp;
        if (exp >= levelUpExp)
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
        return "EXP: " + exp + "/" + levelUpExp;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        levelUpExp = (int)Mathf.Pow(level, 2);
    }
}
