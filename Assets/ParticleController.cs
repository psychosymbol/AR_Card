using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject[] nonParticleObjects;
    public ParticleSystem[] particleList;
    public bool PlayOnAwake = false;
    void Start()
    {
        if(PlayOnAwake)
        {
            playParticle();
        }
    }

    public void playParticle()
    {
        foreach (var item in particleList)
        {
            item.Play();
        }

        foreach (var item in nonParticleObjects)
        {
            item.SetActive(true);
        }
    }
    public void pauseParticle()
    {
        foreach (var item in particleList)
        {
            item.Pause();
        }


        foreach (var item in nonParticleObjects)
        {
            item.SetActive(false);
        }
    }
}
