using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntigravityFieldObj : MonoBehaviour
{
    float power = 15.0f;
    float time = 5.0f;

    void Start()
    {
        GameObject p = GameObject.Find("Player");
        this.transform.parent = p.transform;
        this.transform.localPosition = Vector3.zero;
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
