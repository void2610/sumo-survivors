using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Score: " + ScoreManager.instance.GetScore();
    }
}
