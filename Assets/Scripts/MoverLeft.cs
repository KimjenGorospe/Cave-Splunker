using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
