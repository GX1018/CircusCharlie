using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRing : MonoBehaviour
{
    private float timeAfterSpawn=0;
    public float speed = -0.05f;

    public bool isGrounded = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(-0.02f,0)); 기본
        transform.Translate(new Vector2(speed,0));

        /* Debug.Log(isGrounded);
        if(isGrounded ==true)
        {
             this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-10,0);
        } */
            
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null){
                playerController.Die();
            }
        }

        if(other.tag == "RemoveRing")
        {
            this.gameObject.SetActive(false);
        }

        if(other.tag == "JumpSpace")
        {
            
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10f));
        }

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
}
