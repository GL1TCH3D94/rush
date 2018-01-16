using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMovement : MonoBehaviour {

    public float turnSpeed = 3.0f;
    Vector3 m_lastloc;

	// Use this for initialization
	void Start () {
        m_lastloc = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

            if (m_lastloc != transform.position)
            {
                Vector3 dir = transform.position - m_lastloc;
                dir.Normalize();
                Quaternion lookRot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, turnSpeed * Time.deltaTime);
            }

            m_lastloc = transform.position;
        }
            
}
