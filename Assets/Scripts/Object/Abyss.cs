using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abyss : MonoBehaviour
{
    [SerializeField]
    GameObject deathParticlePrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Enemy>() != null)
        {
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(other.gameObject.GetComponent<Enemy>().GetKillScore());
                ExpManager.instance.AddExp(other.gameObject.GetComponent<Enemy>().GetKillScore());
            }

            ParticleSystem deathParticle = Instantiate(deathParticlePrefab.GetComponent<ParticleSystem>(), other.gameObject.transform.position, Quaternion.identity);
            var renderer = deathParticle.GetComponent<ParticleSystemRenderer>();
            renderer.material.color = other.gameObject.GetComponent<MeshRenderer>().material.color;
            renderer.material.SetColor("_EmissionColor", other.gameObject.GetComponent<MeshRenderer>().material.color);
            deathParticle.Play();

            other.gameObject.GetComponent<RandomAudioContainer>().Play();

            Destroy(other.gameObject);
            Destroy(deathParticle, 3);
        }
        else if (other.gameObject.GetComponent<Player>() != null)
        {
            ScoreManager.instance.SendScore();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
