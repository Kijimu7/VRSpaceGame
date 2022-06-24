using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiontest : MonoBehaviour
{
    public ParticleSystem ringEffect;
    public AudioClip ringSound;
    private AudioSource playerAudio;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }
    
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("test wall");
        
            ringEffect.Play();
            playerAudio.PlayOneShot(ringSound, 1.0f);
            
            
            
        }
    }
}
