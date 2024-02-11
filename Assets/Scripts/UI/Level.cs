using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Level: " + ExpManager.instance.GetLevel();
    }
}
