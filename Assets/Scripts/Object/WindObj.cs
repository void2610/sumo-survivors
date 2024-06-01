using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindObj : MonoBehaviour
{
    private float coefficient = 0.1f;
    private Vector3 velocity = new Vector3(-100, 0, 0);

    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    void OnTriggerStay(Collider col)
    {
        if (col.GetComponent<Rigidbody>() == null || col.gameObject.name == "Player")
        {
            return;
        }
        var relativeVelocity = velocity - col.GetComponent<Rigidbody>().velocity;

        col.GetComponent<Rigidbody>().AddForce(coefficient * relativeVelocity);
    }
}
