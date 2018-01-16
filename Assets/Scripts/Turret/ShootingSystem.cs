using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour {

    public float fireRate;
    public bool beam;
    public List<GameObject> projectileSpawns;
    public GameObject projectile;
    public float fieldOfView;
    private GameObject m_target = null;
    public int damage;
    public ParticleSystem[] flash = new ParticleSystem[4];
    private int i = 0;
    public AudioSource shot;


    List<GameObject> m_lastProjectiles = new List<GameObject>();
    float m_fireTimer = 0.0f;


	// Update is called once per frame
	void Update () {
        if(m_target != null)
        {
            if (beam && m_lastProjectiles.Count <= 0)
            {
                float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(m_target.transform.position - transform.position));
                if (angle < fieldOfView)
                {
                    SpawnProjectiles();
                }

            }
            else if (beam && m_lastProjectiles.Count > 0)
            {
                float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(m_target.transform.position - transform.position));

                if (angle > fieldOfView)
                {
                    while (m_lastProjectiles.Count > 0)
                    {
                        Destroy(m_lastProjectiles[0]);
                        m_lastProjectiles.RemoveAt(0);
                    }
                }
            }
            else
            {
                m_fireTimer += Time.deltaTime;

                if (m_fireTimer >= fireRate)
                {
                    float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(m_target.transform.position - transform.position));

                    if (angle < fieldOfView)
                    {
                        SpawnProjectiles();

                        m_fireTimer = 0.0f;
                    }



                }
            }
        }
		
	}

    void SpawnProjectiles()
    {
        if(!projectile)
        {
            return;
        }
        m_lastProjectiles.Clear();



            if(projectileSpawns[i])
            {
                GameObject shoot;

                shoot = Instantiate(projectile, projectileSpawns[i].transform.position, projectileSpawns[i].transform.rotation);

                flash[i].Play();
            
                shot.Play();
            Debug.Log("nosound?");
            Rigidbody rigid = shoot.GetComponent<Rigidbody>();

                rigid.AddForce(projectileSpawns[i].transform.forward * 5000);

            i++;
            if(i == 4)
            {
                i = 0;
            }



        }
    }
    public void SetTarget(GameObject target)
    {
        m_target = target;
    }
}
