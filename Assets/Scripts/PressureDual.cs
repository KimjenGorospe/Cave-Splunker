using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//if the player steps on the pressure plate it spawns a dart
public class PressureDual: MonoBehaviour {
    public GameObject Dart;
    public GameObject Dart2;
    public Transform Spawner;
    public Transform Spawner2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D Col)
    {
        Instantiate(Dart, Spawner.position, Spawner.rotation);
        Instantiate(Dart2, Spawner2.position, Spawner2.rotation);
    }
}
