using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;
    public float textTime = 2.0f;
    public float textIns = 6.0f;
    public bool isGrounded;
    public bool Treasure;
    public GameObject gameoverText;
    public GameObject restartButton;
    public GameObject victoryText;
    public GameObject exitText;
    public GameObject instructionText;
    public GameObject Diamond;
    public GameObject Boulder;
    public GameObject Exit;
    public Transform Spawner;

    // Use this for initialization
    void Start () {
        gameoverText.SetActive(false);
        restartButton.SetActive(false);
        victoryText.SetActive(false);
        Treasure = false;
        exitText.SetActive(false);
        instructionText.SetActive(true);
	}

    // Update is called once per frame
    void Update() {
        Move();
        textTime -= Time.deltaTime;
        textIns -= Time.deltaTime;
        if (textTime < 0)
        {
            exitText.SetActive(false);
        }
        if (textIns < 0)
        {
            instructionText.SetActive(false);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    void Move()
    {
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown ("Jump") && isGrounded == true) // If you press spacebar, you call the jump function
        {
            Jump();
        }


        if (moveX != 0) //Animation
        {
            GetComponent<Animator>().SetBool("IsRunning", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("IsRunning", false);
        }


        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump() //Makes the Player Jump
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
    }

    void OnCollisionEnter2D(Collision2D col) // Makes the player only jump once until they touch the ground
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        if (col.gameObject.tag == "Spawner")
        {
            isGrounded = true;
        }
        if (col.gameObject.tag == "GroundWall")
        {
            isGrounded = true;
        }
        if (col.gameObject.tag == "Hazard")
        {
            gameoverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
        if(col.gameObject == Diamond)
        {
            Diamond.gameObject.SetActive(false);
            Treasure = true;
            Instantiate(Boulder, Spawner.position, Spawner.rotation);
        }
        if(col.gameObject == Exit && Treasure == true)
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
            victoryText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
        if(col.gameObject == Exit && Treasure == false)
        {
            exitText.SetActive(true);
            textTime = 2.0f;
        }
    }

    void FlipPlayer() //Flips the sprite on the x axis
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
