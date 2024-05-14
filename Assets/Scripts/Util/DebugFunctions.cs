using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugFunctions : MonoBehaviour
{

    void Start()
    {
        if (!Application.isEditor)
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Current State: " + GameManager.instance.currentState);
        if (Input.GetKeyDown(KeyCode.L) && GameManager.instance.currentState == GameState.InGame)
        {
            ExpManager.instance.AddExp(100);
        }
    }
}
