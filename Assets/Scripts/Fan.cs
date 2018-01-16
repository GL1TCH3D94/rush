using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour {

	// Use this for initialization

        public int speed;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0f, speed * Time.deltaTime, 0f);

    }

}
