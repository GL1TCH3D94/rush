using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RangeChecker : MonoBehaviour
{
    TrackingSystem m_tracker;
    ShootingSystem m_shooter;

    private GameObject m_target;

    void Start()
    {
        m_tracker = GetComponent<TrackingSystem>();
        m_shooter = GetComponent<ShootingSystem>();
    }
    private void Update()
    {
        m_shooter.SetTarget(m_target);
        m_tracker.SetTarget(m_target);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_target = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            m_target = null;
        }
    }
}

