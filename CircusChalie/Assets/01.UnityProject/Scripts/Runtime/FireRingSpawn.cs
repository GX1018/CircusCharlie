using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRingSpawn : MonoBehaviour
{
    private GameObject FireRing;
    private GameObject FireRing_2;
    private GameObject FireRing_3;
    private GameObject player;


    private float timeAfterSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;

        player = GameObject.Find("Player");

        FireRing = Resources.Load<GameObject>("Prefabs/FireRing");
        FireRing_2 = Resources.Load<GameObject>("Prefabs/FireRing_2");
        FireRing_3 = Resources.Load<GameObject>("Prefabs/FireRing_3");
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
            if(ranNum <5)
            {
                GameObject ring = Instantiate(FireRing, transform.position, transform.rotation, GameObject.Find("GameObjs").transform);
            }
            else if(5<=ranNum&&ranNum<=8)
            {
                GameObject ring = Instantiate(FireRing_2, transform.position, transform.rotation, GameObject.Find("GameObjs").transform);

            }
            else
            {
                GameObject ring = Instantiate(FireRing_3, new Vector2(transform.position.x, transform.position.y+0.3f), transform.rotation, GameObject.Find("GameObjs").transform);
            }
        }
    }
}
