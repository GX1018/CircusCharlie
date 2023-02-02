using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll_Button : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;
    public bool Jump = false;
    public float speed = 5f;
    public float jumpForce = 5f;

    private bool isGrounded =false;

    public Vector2 newVelocity;

    private Rigidbody2D playerRigidBody;
    private Animator animator;
    private bool isGrounded_button;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        animator =GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded_button = gameObject.GetComponent<PlayerController>().isGrounded;

        Debug.Log($"버튼 그라운디드?{isGrounded_button}");

        if(isGrounded_button == true)
        {
            if(LeftMove)
            {
                newVelocity = new Vector2(-5, 0f);
                playerRigidBody.velocity = newVelocity;
            }

            if(RightMove)
            {
                newVelocity = new Vector2(5, 0f);
                playerRigidBody.velocity = newVelocity;
            }

            if(Jump)
            {
                newVelocity = new Vector2(playerRigidBody.velocity.x, 7.5f);
                
                playerRigidBody.velocity = newVelocity;
            }
        }
        
    }
    
}
