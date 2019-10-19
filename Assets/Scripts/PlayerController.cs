using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    //Properties ( Variables)
    public float xMin, xMax, yMin, yMax;
    //Behaviors (Fuctions/Methods)
}

public class PlayerController : MonoBehaviour {
    //Variable Declaration
    [Header("Movement Settings")]
    public float speed = 12.0f;

    private Rigidbody2D rBody;


	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}
    //Fixed update increments. Used for physics
    void FixedUpdate()
    {
        // Read input
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horiz, vert);

        //Move the Player
        //Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = movement * speed;
    }
}
