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
    //-10 5, 4,-4
    //Variable Declaration
    [Header("Movement Settings")]
    public float speed = 12.0f;
    //public float xMin, xMax, yMin, yMax;

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
        //Debug.Log("x: " + horiz + ",y: " + vert);

        Vector2 movement = new Vector2(horiz, vert);

        //Move the Player
        //Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = movement * speed;

        //Restricts the player from leaving the play area
        /*rBody.position = new Vector2(
            Mathf.Clamp(rBody.position.x, boundary.xMin, boundary.xMax), // Restricts on the X postition to xMin and xMax
            Mathf.Clamp(rBody.position.y, boundary.yMin, boundary.yMax)); // Restricts on the Y postition to yMin and yMax
            */
    }
}
