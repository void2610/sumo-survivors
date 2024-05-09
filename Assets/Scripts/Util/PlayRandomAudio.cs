using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomAudio : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> audioList = new List<AudioClip>();

    private AudioSource audioSource;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    public void Play()
    {
        Debug.Log("Play");
        audioSource.clip = audioList[Random.Range(0, audioList.Count)];
        audioSource.Play();
    }
}
