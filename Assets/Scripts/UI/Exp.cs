using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exp : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = ExpManager.instance.GetUIString();
    }
}
