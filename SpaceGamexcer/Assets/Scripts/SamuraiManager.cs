using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiManager : MonoBehaviour
{
    //Adding hit effect variable
    public ParticleSystem hitEffecct;
    // [SerializeField] private Animator myAnimationController;

    public void OnCollisionEnter(Collision other)
  {
      if (other.gameObject)
      {
          hitEffecct.Play();
         
      }
  }

  // public void OnCollisionEnter(Collider other)
  // {
  //   if (other.CompareTag("Player"))
  //   {
  //     hitEffecct.Play();
      // myAnimationController.SetBool("playAnim", true);
  //   }
  // }
  
  // public void OnCoolisionExit(Collider other)
  // {
  //   if (other.CompareTag("Player"))
  //   {
  //     myAnimationController.SetBool("playAnim", false);
  //   }
  // }
}
