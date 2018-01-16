using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour {

    // Use this for initialization

    public float damage = 0.5f; //sets damage dealt by each shot
    private void OnCollisionEnter(Collision collision)
    {
        PlayerHealth health = collision.transform.GetComponent<PlayerHealth>();
        if (health != null && (collision.gameObject.tag == "Player")) //check hit object has target script
            {
                health.TakeDamage(damage); //applys damage to target
            }
        Destroy();
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
