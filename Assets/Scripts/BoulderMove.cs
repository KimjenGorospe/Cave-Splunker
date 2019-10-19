using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script handles the movement of the boulder that spawn at the end of the level
public class BoulderMove : MonoBehaviour {

    //Variable Declaration
    public float speed;

    // Use this for initialization
    void Start()
    {
        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = -transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
