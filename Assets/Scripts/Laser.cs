using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    

    private void OnTriggerEnter(Collider other)

    {
        GameObject[] laserSwitch = GameObject.FindGameObjectsWithTag("Laser");

        for (int i = 0; i < laserSwitch.Length; i++)
        {
            Laser_Switch tempLaser = laserSwitch[i].GetComponent<Laser_Switch>();
            tempLaser.On();
        }
        

    }

    // Use this for initialization
    void Start ()
    {
        GameObject[] laserSwitch = GameObject.FindGameObjectsWithTag("Laser");

        for (int i = 0; i < laserSwitch.Length; i++)
        {
            Laser_Switch tempLaser = laserSwitch[i].GetComponent<Laser_Switch>();
            tempLaser.Off();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
