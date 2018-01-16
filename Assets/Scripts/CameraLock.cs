using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.position = GameObject.FindWithTag("Player").transform.position;
    }
}
