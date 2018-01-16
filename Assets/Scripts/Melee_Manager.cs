using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Manager : MonoBehaviour {

    public int damage; //sets damage dealt by each shot
    public float fireRate = 0.5f;
    private bool canShoot = true;
    public GameObject bullet;
    public GameObject spawn;
    private GameObject shoot;
    public float range = 2.0f;
    public int count = 0;
    public AudioSource sound;
    public ParticleSystem flash = new ParticleSystem();



    // Use this for initialization
    void Start ()
    {

	}

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1") && canShoot) //on left mouse click
        {
            Debug.Log("Timer");
            StartCoroutine(FireTimer());
        }
    }
    private IEnumerator FireTimer()
    {

        Attack();
        canShoot = false;
        yield return new WaitForSeconds(fireRate);
        canShoot = true;

    }

    void Attack()
    {


        Debug.Log("Shot");
        shoot = Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);

        sound.Play();
        flash.Play();
        Rigidbody rigid = shoot.GetComponent<Rigidbody>();

        rigid.AddForce(spawn.transform.right * -5000);


    }
}
