using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasicProjectile : MonoBehaviour {

    public float speed = 5.0f;
    public abstract void fireProjectile(GameObject launcher, GameObject target, int damage);

}
