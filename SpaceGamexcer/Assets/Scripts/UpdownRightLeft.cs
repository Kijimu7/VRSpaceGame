using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdownRightLeft : MonoBehaviour
{
    private Transform attacher;
    private Vector3 startPos;

    public int height = 15; //max height of ball movement
    
    void Start()
    {
        attacher = this.transform.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        //move only y axis
        //transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, height), transform.position.z);
    }
}
