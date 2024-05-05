using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private float power = 150f;
    private float radius = 5.0f;
    private float time = 1.5f;

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(this.transform.position, radius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(power, transform.position, radius, 3.0f);
            }
        }

        Destroy(this.gameObject);
    }

    void Start()
    {
        Invoke("Explode", time);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
