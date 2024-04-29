using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameState currentState = GameState.InGame;

    public void ChangeGameState(GameState state)
    {
        switch (state)
        {
            case GameState.InGame:
                Time.timeScale = 1;
                UIManager.instance.ChangeActiveUI(GameState.InGame);
                break;
            case GameState.Pause:
                Time.timeScale = 0;
                UIManager.instance.ChangeActiveUI(GameState.Pause);
                break;
            case GameState.LevelUp:
                Time.timeScale = 0;
                UIManager.instance.ChangeActiveUI(GameState.LevelUp);
                break;
            default:
                break;
        }

        currentState = state;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentState == GameState.InGame)
            {
                this.ChangeGameState(GameState.Pause);
            }
            else if (currentState == GameState.Pause)
            {
                this.ChangeGameState(GameState.InGame);
            }
        }
    }

    public static GameManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
