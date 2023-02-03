using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireRingSpawn : MonoBehaviour
{
    private GameObject FireRing;
    private GameObject FireRing_2;
    private GameObject FireRing_3;
    private GameObject player;

    //풀링에 쓸 변수
    private int ringNum = 0;


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
        string sceneName = SceneManager.GetActiveScene().name;

        if(sceneName== GData.SCENE_NAME_PLAY)
        {
        transform.position = new Vector3((PlayerPos.x+18f), transform.position.y, transform.position.z);
        }

        if(sceneName== GData.SCENE_NAME_PLAY2)
        {
        transform.position = new Vector3((PlayerPos.x+18f), transform.position.y, transform.position.z);
        }
        
        timeAfterSpawn +=Time.deltaTime;


        if(timeAfterSpawn>5)
        {
            int ranNum = Random.Range(0,10);
            timeAfterSpawn=0f;

            ActiveRing();

            //RingPool.Instance.MakeRing();

            /* if(ranNum <5)
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
            } */
        }
    }

    public void ActiveRing()
    {
        //Debug.Log($"{RingPool.ringPool[0]} 리스트");
        Debug.Log($"{RingPool.monkeyPool[0]} monkey");
        string sceneName = SceneManager.GetActiveScene().name;

        if(sceneName== GData.SCENE_NAME_PLAY)
        {
            if(ringNum > RingPool.ringPool.Count)
            {
                ringNum = 0;
            }

            RingPool.ringPool[ringNum].transform.position = this.transform.position;
            
            RingPool.ringPool[ringNum].GetComponent<RectTransform>().localScale = new Vector2(1,1);

            RingPool.ringPool[ringNum].SetActive(true);
            ringNum++;
        }

        else if(sceneName == GData.SCENE_NAME_PLAY2)
        {
            if(ringNum > RingPool.monkeyPool.Count)
            {
                ringNum = 0;
            }

            RingPool.monkeyPool[ringNum].transform.position = this.transform.position;
            
            RingPool.monkeyPool[ringNum].GetComponent<RectTransform>().localScale = new Vector2(4,4);

            RingPool.monkeyPool[ringNum].SetActive(true);
            ringNum++;
        }
    }
}
