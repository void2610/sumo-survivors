using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        //Enemyクラスを継承しているオブジェクトが落ちたら消す
        if (other.gameObject.GetComponent<Enemy>() != null)
        {
            ScoreManager.instance.AddScore(other.gameObject.GetComponent<Enemy>().GetKillScore());
            ExpManager.instance.AddExp(other.gameObject.GetComponent<Enemy>().GetKillScore());
            Destroy(other.gameObject);
        }
        else if (other.gameObject.GetComponent<Player>() != null)
        {
            other.gameObject.transform.position = new Vector3(0, 2, 0);
            ScoreManager.instance.ResetScore();
            ExpManager.instance.ResetExp();
        }
    }
}
