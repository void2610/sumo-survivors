using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntigravityFieldObj : MonoBehaviour
{
    float power = 15.0f;
    float time = 5.0f;

    void Start()
    {
        Destroy(this.gameObject, time);
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(Vector3.up * power, ForceMode.Acceleration);
        }
    }
}
