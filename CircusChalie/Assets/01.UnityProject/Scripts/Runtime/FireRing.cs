using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRing : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-0.02f,0));
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null){
                playerController.Die();
            }
        }
    }
}
