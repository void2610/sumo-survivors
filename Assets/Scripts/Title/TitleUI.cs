using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnSliderChanged(float value)
    {
        AudioListener.volume = value;
    }

    private void Start()
    {
        AudioListener.volume = 0.5f;
    }
}
