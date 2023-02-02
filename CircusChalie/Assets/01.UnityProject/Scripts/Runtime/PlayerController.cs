using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isGrounded = false;
    private bool isDead = false;
    private bool isClear =false;
    private Rigidbody2D playerRigidBody;
    private Animator animator;
    //private BoxCollider2D boxCollider;


    private GameObject lion;

    public float jumpForce = 450f;
    public float speed = 5f;

    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();

        lion = GameObject.Find("Player_Lion");
        
        
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.x);
        //Debug.Log(transform.position.y);

        Debug.Log($"컨트롤 이즈그라운디드?{isGrounded}");

        if(isDead == true){
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            lion.GetComponent<BoxCollider2D>().enabled = false;

            GameManager.Instance.Die();

            //playerRigidBody.AddForce(new Vector2(0, 1));

            return;
            //GFunc.LoadScene(GData.SCENE_NAME_PLAY);
            }
        
        if(isClear == true)
        {
            playerRigidBody.velocity = new Vector2(0,0);
            transform.position = new Vector2(173, -0.025f);
        }

        if(isGrounded ==true)
        {
            float xInput = Input.GetAxis("Horizontal");
            float xSpeed = xInput * speed;
            Vector2 newVelocity = new Vector2(xSpeed, 0f);
            
            playerRigidBody.velocity = newVelocity;


            /*if(Input.GetMouseButtonDown(0))
            {
                playerRigidBody.AddForce(new Vector2(0, jumpForce));
                //playerRigidBody.velocity = Vector2.zero;
                isGrounded=false;
            }*/
           
        }
        animator.SetBool("Grounded", isGrounded);

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionStay2D(Collision2D other) {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.collider.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    public void GettingGold()
    {
        score += 500;
    }

    public void JumpJar()
    {
        score += 200;
    }

    public void JumpFireRing()
    {
        score += 100;
    }


    public void Die(){
        animator.SetTrigger("Die"); 
        isDead =true;
    }

    public void Clear()
    {
        animator.SetTrigger("Clear");
        isClear = true;
    }
}
