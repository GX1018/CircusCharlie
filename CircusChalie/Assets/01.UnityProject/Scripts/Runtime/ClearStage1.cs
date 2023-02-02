using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStage1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            
            if(playerController != null)
            {
                playerController.Clear();
                gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
    }
}
