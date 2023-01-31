using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isGrounded = false;
    private bool isDead = false;
    private Rigidbody2D playerRigidBody;

    public float jumpForce = 450f;
    public float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded ==true)
        {
            float xInput = Input.GetAxis("Horizontal");
            float xSpeed = xInput * speed;

            Vector2 newVelocity = new Vector2(xSpeed, 0f);
            playerRigidBody.velocity = newVelocity;
            if(Input.GetMouseButtonDown(0))
            {
                playerRigidBody.AddForce(new Vector2(0, jumpForce));
                //playerRigidBody.velocity = Vector2.zero;
                isGrounded=false;
            }

            
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        
    }
}
