using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {
    public GameObject Dart;
    public Transform Spawner;
    public Transform Spawner2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
   private void OnTriggerEnter2D(Collider2D Col)
    {
        Instantiate(Dart, Spawner.position, Spawner.rotation);
        Instantiate(Dart, Spawner2.position, Spawner2.rotation);
    }
}
