using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingProjectile : BasicProjectile {

    GameObject m_target;

    private void Update()
    {
        if (m_target)
        {
            transform.position += Vector3.MoveTowards(transform.position, m_target.transform.position, speed * Time.deltaTime);
        }
    }

    public override void fireProjectile(GameObject launcher, GameObject target, int damage)
    {
        if (target)
            m_target = target;
    }
}
