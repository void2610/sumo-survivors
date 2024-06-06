using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindObj : MonoBehaviour
{
    private float time = 5.0f;
    private float coefficient = 0.1f;
    private float power = 100;

    public void Init(float time, float coefficient, float power)
    {
        this.time = time;
        this.coefficient = coefficient;
        this.power = power;
    }

    void Start()
    {
        Destroy(this.gameObject, time);
    }

    void OnTriggerStay(Collider col)
    {
        if (col.GetComponent<Rigidbody>() == null || col.gameObject.name == "Player")
        {
            return;
        }
        var relativeVelocity = new Vector3(-power, 0, 0) - col.GetComponent<Rigidbody>().velocity;

        col.GetComponent<Rigidbody>().AddForce(coefficient * relativeVelocity);
    }
}
