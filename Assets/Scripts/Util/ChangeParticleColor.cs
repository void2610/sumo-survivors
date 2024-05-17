using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParticleColor : MonoBehaviour
{

    public void ChangeColor(Color color)
    {
        ParticleSystem particle = this.GetComponent<ParticleSystem>();
        ParticleSystem.MainModule main = particle.main;
        main.startColor = color;
    }
}
