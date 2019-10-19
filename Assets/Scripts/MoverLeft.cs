using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//allows the spear / darts that spawn to move left
public class MoverLeft : MonoBehaviour {

    //Variable Declaration
    public float speed;

	// Use this for initialization
	void Start ()
    {
        Rigidbody2D rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = -transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {

        }
    //if they hit anything it automatically destroys the spear
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "GroundWall")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Hazard")
        {
            Destroy(this.gameObject);
        }
    }
}
