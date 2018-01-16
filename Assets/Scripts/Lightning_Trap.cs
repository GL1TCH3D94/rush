using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning_Trap : MonoBehaviour {

    // Use this for initialization

    public int dischargeRate = 5;
    public int zapRate = 1;
    private bool canShoot = true;
    public int damage = 20;
    public AudioSource sound;
    private bool state;

    void Start ()
    {
        ParticleSystem particle = this.GetComponent<ParticleSystem>();
        particle.Stop();
    }



    private IEnumerator Discharge()
    {
        Fire();
        canShoot = false;
        yield return new WaitForSeconds(dischargeRate);
        Stop();
        yield return new WaitForSeconds(dischargeRate);
        canShoot = true;

    }
    // Update is called once per frame
    void Update ()
    {
        if(canShoot)
        {
            StartCoroutine(Discharge());
        }
        
    }
    void Fire()
    {
        ParticleSystem particle = this.GetComponent<ParticleSystem>();
        particle.Play();
        sound.Play();
        state = true;

    }
    void Stop()
    {
        ParticleSystem particle = this.GetComponent<ParticleSystem>();
        particle.Stop();
        state = false;
    }
    void OnTriggerEnter(Collider other)
    {
        PlayerHealth health = other.transform.GetComponent<PlayerHealth>(); //gets target script data from hit object

        if (health != null && (canShoot != true)) //check hit object has target script
        {
            StartCoroutine(DoDamage(health));//applys damage to target
        }
    }
    private IEnumerator DoDamage(PlayerHealth health)
    {
        while(state == true)
        {
            health.TakeDamage(damage);
            yield return new WaitForSeconds(zapRate);
        }
        
    }

}
