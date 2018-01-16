using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressAlongPathSpeed : MonoBehaviour {

    public PathGenerator path = null;
    public float speed = 2.0f;

    float m_progress = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

            m_progress += ((1.0f / path.GetTotalDistance()) * speed) * Time.deltaTime;

            Vector3 pos = new Vector3();
            path.GetPointOnPath(m_progress, ref pos);
            transform.position = pos;
		
	}
}
