using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private AudioClip explosionSound;
    private float power = 180f;
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

        ParticleSystem particle = Instantiate(Resources.Load<GameObject>("Prefabs/Particle/ExplosionParticle").GetComponent<ParticleSystem>(), this.transform.position, Quaternion.identity);
        particle.Play();
        Destroy(particle, 3);
        SoundManager.instance.PlaySe(explosionSound, 0.6f);

        Destroy(this.gameObject);
    }

    void Start()
    {
        Invoke("Explode", time);
    }
}
