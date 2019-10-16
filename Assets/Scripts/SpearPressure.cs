using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearPressure : MonoBehaviour {

    public GameObject Spear;
    public GameObject Spear1;
    public GameObject Spear2;
    public float SpearTime = 2.0f;

    // Use this for initialization
    void Start () {
        Spear.SetActive(false);
        Spear1.SetActive(false);
        Spear2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SpearTime -= Time.deltaTime;
        if (SpearTime < 0)
        {
            Spear.SetActive(false);
            Spear1.SetActive(false);
            Spear2.SetActive(false);
        }
    }
   private void OnTriggerEnter2D(Collider2D col)
    {
        Spear.SetActive(true);
        Spear1.SetActive(true);
        Spear2.SetActive(true);
        SpearTime = 2.0f;
    }
}
