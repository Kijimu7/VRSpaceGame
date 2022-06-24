using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpandDown : MonoBehaviour
{
    private Transform attacher;

    public int height = 9; //max height of ball movement
    
    void Start()
    {
        attacher = this.transform.Find("Ring");
    }

    // Update is called once per frame
    void Update()
    {
        //move only y axis
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, height), transform.position.z);
    }
}
