using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{

    // Use this for initialization

    public float damage = 40f; //sets damage dealt by each shot

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        Target target = collision.transform.GetComponent<Target>(); //gets target script data from hit object

        if (target != null && (collision.gameObject.tag == "EnemyObject")) //check hit object has target script
        {
            Debug.Log("Hit Target");
            target.TakeDamage(damage); //applys damage to target
        }
        Destroy();
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
