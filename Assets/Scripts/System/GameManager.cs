using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
                UIManager.instance.ChangeActiveUI(UIManager.UIState.InGame);
            }
            else
            {
                isPaused = true;
                UIManager.instance.ChangeActiveUI(UIManager.UIState.Pause);
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
