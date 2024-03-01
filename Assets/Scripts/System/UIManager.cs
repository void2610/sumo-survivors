using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum UIState
    {
        InGame,
        Pause,
        LevelUp,
    }
    public UIState currentState = UIState.InGame;

    public static UIManager instance;

    private GameObject[] inGameUIs;
    private GameObject[] pauseUIs;
    private GameObject[] levelUpUIs;

    public void ChangeActiveUI(UIState state)
    {
        switch (state)
        {
            case UIState.InGame:
                currentState = UIState.InGame;
                foreach (GameObject ui in inGameUIs)
                {
                    ui.SetActive(true);
                }
                foreach (GameObject ui in pauseUIs)
                {
                    ui.SetActive(false);
                }
                foreach (GameObject ui in levelUpUIs)
                {
                    ui.SetActive(false);
                }
                break;
            case UIState.Pause:
                currentState = UIState.Pause;
                foreach (GameObject ui in inGameUIs)
                {
                    ui.SetActive(false);
                }
                foreach (GameObject ui in pauseUIs)
                {
                    ui.SetActive(true);
                }
                foreach (GameObject ui in levelUpUIs)
                {
                    ui.SetActive(false);
                }
                break;
            case UIState.LevelUp:
                currentState = UIState.LevelUp;
                foreach (GameObject ui in inGameUIs)
                {
                    ui.SetActive(false);
                }
                foreach (GameObject ui in pauseUIs)
                {
                    ui.SetActive(false);
                }
                foreach (GameObject ui in levelUpUIs)
                {
                    ui.SetActive(true);
                }
                break;
        }
    }

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

    void Start()
    {
        inGameUIs = GameObject.FindGameObjectsWithTag("InGameUI");
        pauseUIs = GameObject.FindGameObjectsWithTag("PauseUI");
        levelUpUIs = GameObject.FindGameObjectsWithTag("LevelUpUI");

        ChangeActiveUI(UIState.InGame);
    }
}
