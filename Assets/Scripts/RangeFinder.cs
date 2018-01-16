using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeFinder : MonoBehaviour {

    public Transform player;
    public Transform enemy;
    private Vector3 distance;
    private float distanceFrom;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        distance = (enemy.position - player.position);
        distance.y = 0;
        distanceFrom = distance.magnitude;
        distance /= distanceFrom;


        if (distanceFrom < 20)
        {
            ProgressAlongPathSpeed speed = GetComponent<ProgressAlongPathSpeed>();
            ProgressAlongPathTime time = GetComponent<ProgressAlongPathTime>();
            RotateToMovement rotate = GetComponent<RotateToMovement>();
            AiAttack attack = GetComponent<AiAttack>();
            AIMove move = GetComponent<AIMove>();

            speed.enabled = false;
            time.enabled = false;
            rotate.enabled = false;
            attack.enabled = true;
            move.enabled = true;
            
        }
        else
        {
            ProgressAlongPathSpeed speed = GetComponent<ProgressAlongPathSpeed>();
            ProgressAlongPathTime time = GetComponent<ProgressAlongPathTime>();
            RotateToMovement rotate = GetComponent<RotateToMovement>();
            AiAttack attack = GetComponent<AiAttack>();
            AIMove move = GetComponent<AIMove>();

            speed.enabled = true;
            time.enabled = true;
            rotate.enabled = true;
            attack.enabled = false;
            move.enabled = false;
        }
    }
}
