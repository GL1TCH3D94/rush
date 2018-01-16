using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiAttack : MonoBehaviour {


    public Transform player;
    public Transform enemy;
    public GameObject bullet;
    public GameObject[] spawn = new GameObject[2];
    private Vector3 distance;
    private float distanceFrom;
    public float fireRate = 0.5f;
    private bool canShoot = true;
    public ParticleSystem[] flash = new ParticleSystem[2];
    private int count;
    public AudioSource sound;
    public float angle = 10.0f;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        // Calculate the distance between the player  the enemy

        distance = (enemy.position - player.position);
        distance.y = 0;
        distanceFrom = distance.magnitude;
        distance /= distanceFrom;

        // If the player is 20m away from the enemy, ATTACK!

         if(distanceFrom < 20 && canShoot)
        {
            StartCoroutine(FireTimer());
        }
    }
    public float GetDistanceFrom()
    {
        return distanceFrom;
    }


    private IEnumerator FireTimer()
    {
        
        Attack(count);
        canShoot = false;
        yield return new WaitForSeconds(fireRate);
        canShoot = true;
        if(count == 0)
        {
            count++;
        }
        else
        {
            count = 0;
        }
    }

    void Attack(int count)
    {

        
            enemy.LookAt(player);

            GameObject shoot;

        if(count == 0)
        {

            shoot = Instantiate(bullet, spawn[0].transform.position, spawn[0].transform.rotation);

            flash[0].Play();
            sound.Play();

            Rigidbody rigid = shoot.GetComponent<Rigidbody>();

            rigid.AddForce(spawn[0].transform.right * -5000);
        }
        else if(count == 1)
        {
            shoot = Instantiate(bullet, spawn[1].transform.position, spawn[1].transform.rotation);

            flash[1].Play();
            sound.Play();

            Rigidbody rigid = shoot.GetComponent<Rigidbody>();

            rigid.AddForce(spawn[1].transform.right * -5000);
        }



    }
}
