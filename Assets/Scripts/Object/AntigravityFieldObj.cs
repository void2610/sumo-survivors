using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntigravityFieldObj : MonoBehaviour
{
    float time = 3.0f;

    void Start()
    {
        Destroy(this.gameObject, time);
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null && other.name != "Player")
        {
            rb.AddForce(Vector3.up * StatusManager.instance.ANTIGRAVITY_POWER / rb.mass, ForceMode.Acceleration);
        }
    }
}
