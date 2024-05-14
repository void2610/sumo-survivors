using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abyss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Enemy>() != null)
        {
            ScoreManager.instance.AddScore(other.gameObject.GetComponent<Enemy>().GetKillScore());
            ExpManager.instance.AddExp(other.gameObject.GetComponent<Enemy>().GetKillScore());

            ParticleSystem deathParticle = Instantiate(Resources.Load<GameObject>("Prefabs/Particle/DeathParticle").GetComponent<ParticleSystem>(), other.gameObject.transform.position, Quaternion.identity);
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
