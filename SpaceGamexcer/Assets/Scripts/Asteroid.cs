using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GDTools.ObjectPooling;

public class Asteroid : PoolObject
{
    //components references:
    public Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    public override void OnObjectDestroy()
    {
        base.OnObjectDestroy();
        rb.velocity = Vector3.zero;
    }
}
