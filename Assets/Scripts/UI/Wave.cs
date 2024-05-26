using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wave : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI waveCount;
    [SerializeField]
    private TextMeshProUGUI waveMassage;
    public void ShowWaveMassage(string massage)
    {
        StartCoroutine(ShowWaveMassageCoroutine(massage));
    }

    private IEnumerator ShowWaveMassageCoroutine(string massage)
    {
        waveMassage.text = massage;
        yield return new WaitForSeconds(2.0f);
        waveMassage.text = "";
    }
    void Start()
    {
        waveMassage.text = "";
    }
    void Update()
    {
        if (WaveManager.instance == null)
        {
            return;
        }
        waveCount.text = "Wave: " + WaveManager.instance.GetWave();
    }
}
