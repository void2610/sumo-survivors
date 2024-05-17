using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wave : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Wave: " + WaveManager.instance.GetWave();
    }
}
