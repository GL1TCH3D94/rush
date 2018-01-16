using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Switch : MonoBehaviour {

    public AudioSource sound;

    public int damage = 1000;
    
    private int trigger = 0;

    public void On()
    {
        ParticleSystem particle = this.GetComponent<ParticleSystem>();
        particle.Play();
        trigger = 1;
        if(sound)
        {
            sound.Play();
        }
        
    }
    public void Off()
    {
        ParticleSystem particle = this.GetComponent<ParticleSystem>();
        particle.Stop();
        trigger = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth health = other.transform.GetComponent<PlayerHealth>(); //gets target script data from hit object

        if (health != null && (trigger == 1)) //check hit object has target script
        {
           health.TakeDamage(damage); //applys damage to target
        }
    }
}
