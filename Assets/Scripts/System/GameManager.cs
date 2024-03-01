using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameState currentState = GameState.InGame;
    private bool isPaused = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                isPaused = false;
                UIManager.instance.ChangeActiveUI(GameState.InGame);
            }
            else
            {
                isPaused = true;
                UIManager.instance.ChangeActiveUI(GameState.Pause);
            }
        }

        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
