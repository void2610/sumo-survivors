using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject player;
    [SerializeField]
    private Vector3 offset;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}
