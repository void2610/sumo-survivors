using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioContainer : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> audioList = new List<AudioClip>();
    public void Play()
    {
        SoundManager.instance.PlaySe(audioList[Random.Range(0, audioList.Count)]);
    }
}
