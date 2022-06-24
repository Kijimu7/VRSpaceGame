using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingEffect : MonoBehaviour
{
    public bool ringParticle;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ring"))
        {
            Debug.Log("test");
            ringParticle = true;
            
        }
    }
}
