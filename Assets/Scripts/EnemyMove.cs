using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Source File Name: Player Move
 * Author's Name: Kimjen Gorospe
 * Last Modified By: November 2 2019
 * Program Description: Controls Movement of the Enemy
 */
public class EnemyMove : MonoBehaviour
{
    public float speed;
    private bool facingRight = true;
    public float time;
    public float startTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        time -= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 0)
        {
            facingRight = !facingRight;
            Vector2 localScale = gameObject.transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
        if (facingRight)
        {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
        }

        if (!facingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
