using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject canvas;
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(canvas.activeInHierarchy == false)
            {
                canvas.SetActive(true);
                Time.timeScale = 0;

            }
            else
            {
                canvas.SetActive(false);
                Time.timeScale = 1;

            }
        }
	}
}
