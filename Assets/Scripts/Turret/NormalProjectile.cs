using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalProjectile : BasicProjectile {

    Vector3 m_direction;
    bool m_fired;

    private void Update()
    {
        if(m_fired)
        {
            transform.position += m_direction * (speed * Time.deltaTime);
        }
    }

    public override void fireProjectile(GameObject launcher, GameObject target, int damage)
    {
        if (launcher && target)
            m_direction = (target.transform.position - launcher.transform.position).normalized;
            m_fired = true;
    }
}
