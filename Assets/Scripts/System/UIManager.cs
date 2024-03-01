using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField]
    private CanvasGroup inGameUIs;
    [SerializeField]
    private CanvasGroup pauseUIs;
    [SerializeField]
    private CanvasGroup levelUpUIs;

    public void ChangeActiveUI(GameState state)
    {
        switch (state)
        {
            case GameState.InGame:
                ChangeActiveUI(inGameUIs, true);
                ChangeActiveUI(pauseUIs, false);
                ChangeActiveUI(levelUpUIs, false);
                break;
            case GameState.Pause:
                ChangeActiveUI(inGameUIs, true);
                ChangeActiveUI(pauseUIs, true);
                break;
            case GameState.LevelUp:
                ChangeActiveUI(inGameUIs, true);
                ChangeActiveUI(pauseUIs, false);
                ChangeActiveUI(levelUpUIs, true);
                break;
        }
    }

    private void ChangeActiveUI(CanvasGroup canvasGroup, bool isActive)
    {
        canvasGroup.alpha = isActive ? 1 : 0;
        canvasGroup.blocksRaycasts = isActive;
        canvasGroup.interactable = isActive;
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
        ChangeActiveUI(GameState.InGame);
    }
}
