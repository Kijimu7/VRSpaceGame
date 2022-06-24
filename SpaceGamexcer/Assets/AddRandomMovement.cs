using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;


public class AddRandomMovement : MonoBehaviour
{
    public float minSpinSpeed = 3f; //how fast asteroid spins
    public float maxSpinSpeed = 8f;

    public float minThrust = 100; //how fast asteroid will move
    public float maxThrust = 500f; //how fast asteroid will move
    private float spinSpeed;
  
    
   
    // Start is called before the first frame update
    void Start()
    {
        spinSpeed = Random.Range(minSpinSpeed, maxSpinSpeed);
        float thrust = Random.Range(minThrust, maxThrust);
        // Rigidbody rg = GetComponent<Rigidbody>();
        // rg.AddForce(transform.forward * thrust, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
      
    }

    void FixedUpdate()
    {
        Rigidbody rg = GetComponent<Rigidbody>();
        ApplyForceToReachVelocity(rg, Vector3.forward * 10, 0.1f);
    }
    public static void ApplyForceToReachVelocity(Rigidbody rigidbody, Vector3 velocity, float force = 1, ForceMode mode = ForceMode.Force)
    {
        if (force == 0 || velocity.magnitude == 0)
            return;

        velocity = velocity + velocity.normalized * 0.2f * rigidbody.drag;

        //force = 1 => need 1 s to reach velocity (if mass is 1) => force can be max 1 / Time.fixedDeltaTime
        force = Mathf.Clamp(force, -rigidbody.mass / Time.fixedDeltaTime, rigidbody.mass / Time.fixedDeltaTime);

        //dot product is a projection from rhs to lhs with a length of result / lhs.magnitude https://www.youtube.com/watch?v=h0NJK4mEIJU
        if (rigidbody.velocity.magnitude == 0)
        {
            rigidbody.AddForce(velocity * force, mode);
        }
        else
        {
            var velocityProjectedToTarget = (velocity.normalized * Vector3.Dot(velocity, rigidbody.velocity) / velocity.magnitude);
            rigidbody.AddForce((velocity - velocityProjectedToTarget) * force, mode);
        }
    }

    
   
}
