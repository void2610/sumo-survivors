using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntigravityFieldObj : MonoBehaviour
{
    float time = 3.0f;
    float power = 15f;
    float radius = 5.0f;

    public void Init(float time, float power, float radius)
    {
        this.time = time;
        this.power = power;
        this.radius = radius;
    }

    void Start()
    {
        this.transform.localScale = new Vector3(radius, 1, radius);
        ParticleSystem ps = this.transform.GetChild(0).GetComponent<ParticleSystem>();
        var shape = ps.shape;
        shape.scale = new Vector3(radius, radius, 0.1f);

        Destroy(this.gameObject, time);
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null && other.name != "Player")
        {
            rb.AddForce(Vector3.up * power / rb.mass, ForceMode.Acceleration);
        }
    }
}
