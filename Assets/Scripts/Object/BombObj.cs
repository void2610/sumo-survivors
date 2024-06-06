using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombObj : MonoBehaviour
{
    [SerializeField]
    private AudioClip explosionSound;
    private float power = 450f;
    private float radius = 6.0f;
    private float time = 1.5f;

    public void Init(float power, float radius, float time)
    {
        this.power = power;
        this.radius = radius;
        this.time = time;
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(this.transform.position, radius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(power, transform.position, radius, 5.0f);
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
