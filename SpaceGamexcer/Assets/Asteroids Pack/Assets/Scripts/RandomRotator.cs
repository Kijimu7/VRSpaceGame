using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField] private float tumble;

    //variable for floating object
    public Vector3 moveDirection;
    public float speed = 3;



    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;

    }

    public void OnBecameInvisible()
    {
        Debug.Log("it is invisible");
        gameObject.SetActive(false);
    }

public void keyDown(){
    if (Input.GetKeyDown("space")){
        FixedUpdate();
    }
}
        
    public void FixedUpdate()
    {
        transform.Translate(moveDirection, Space.World);
        // Debug.Log("visible");
        //     GameObject ast = ObjectPool.instance.GetPooledObject();
        //     if (ast != null)
        //     {
        //         ast.transform.Translate(moveDirection * speed, Space.World);
        //         ast.SetActive(true);
        //
        //     }
        
    }
}