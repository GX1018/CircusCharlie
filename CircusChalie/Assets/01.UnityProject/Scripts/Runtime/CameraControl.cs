using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameObject player;
    //private Rigidbody2D cameraRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        //cameraRigidbody= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = player.transform.position;

        //Debug.Log(PlayerPos.x);
        //Debug.Log(transform.position.x);

        
        
        if(PlayerPos.x >= 162f){
            transform.position = new Vector3(167.5f , transform.position.y, transform.position.z);
        }
        else if ( PlayerPos.x <= -6.25f){
            transform.position = new Vector3(-0.75f , transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3((PlayerPos.x+5.5f), transform.position.y, transform.position.z);
        }
    }
}
