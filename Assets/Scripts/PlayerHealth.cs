using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text healthText;
    public static float health = 100f; //object health
    public GameObject gameoverCanvas;
    public GameObject cameraNew;

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
        cameraNew.SetActive(true);
        gameoverCanvas.SetActive(true);
        Destroy(this.gameObject);
        Cursor.visible = true;
    }

    void Update()
    {
        healthText.text = "HEALTH : " + health;

        if (health <= 0)
        {
            gameoverCanvas.SetActive(true);
        }
    }
}
