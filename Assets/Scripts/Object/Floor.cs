using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField]
    private float initialSize;
    void Start()
    {
        initialSize = this.transform.localScale.x;
    }

    void Update()
    {
        this.transform.localScale = new Vector3(StatusManager.instance.STAGE_SIZE * initialSize, 1, StatusManager.instance.STAGE_SIZE * initialSize);
    }
}
