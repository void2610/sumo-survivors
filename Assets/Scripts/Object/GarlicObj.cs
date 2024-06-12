using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicObj : MonoBehaviour
{
    private float power = 15f;
    private float radius = 5.0f;
    private Transform player;

    public void Init(float power, float radius, Transform player)
    {
        this.power = power;
        this.radius = radius;
        this.player = player;
    }

    public void DestroyGarlic()
    {
        foreach (Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }
        Destroy(this.gameObject);
    }

    void Start()
    {
        this.transform.localScale = new Vector3(radius, 1, radius);
        ParticleSystem ps = this.transform.GetChild(0).GetComponent<ParticleSystem>();
        var shape = ps.shape;
        shape.scale = new Vector3(radius, radius, 0.1f);
    }

    void Update()
    {
        this.transform.position = player.position;
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        Vector3 direction = (other.transform.position - this.transform.position).normalized;

        if (rb != null && other.tag != "Player")
        {
            rb.AddForce(direction * power / rb.mass, ForceMode.Acceleration);
        }
    }
}
