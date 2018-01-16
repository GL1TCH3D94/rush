using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 100f; //object health

    public void TakeDamage(float Amount)
    {
        health -= Amount; //deducts damage
        if (health <= 0) //runs destroy method if criteria is met
        {
            Destroy();
        }
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
