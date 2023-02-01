using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRingSpawn : MonoBehaviour
{
    public GameObject FireRing;
    public GameObject FireRing_2;

    public GameObject player;


    private float timeAfterSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;

        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 PlayerPos = player.transform.position;

        transform.position = new Vector3((PlayerPos.x+18f), transform.position.y, transform.position.z);
        
        timeAfterSpawn +=Time.deltaTime;


        if(timeAfterSpawn>3)
        {
            int ranNum = Random.Range(0,10);
            timeAfterSpawn=0f;
            if(ranNum <7)
            {
                GameObject ring = Instantiate(FireRing, transform.position, transform.rotation, GameObject.Find("GameObjs").transform);
            }
            else{
                GameObject ring = Instantiate(FireRing_2, transform.position, transform.rotation, GameObject.Find("GameObjs").transform);

            }
        }
    }
}
