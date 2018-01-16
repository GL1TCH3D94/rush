using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Follow : MonoBehaviour {
    // Update is called once per frame
    public float zDistance = 50.0f;
    void Update () {
        

            Vector3 mousePos = Input.mousePosition;
        Vector3 random = new Vector3(mousePos.x, mousePos.y, zDistance);
            this.transform.LookAt(Camera.main.ScreenToWorldPoint(random));
    }
}
