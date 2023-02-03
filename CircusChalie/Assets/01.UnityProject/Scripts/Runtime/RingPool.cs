using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RingPool : MonoBehaviour
{
    private static RingPool instance;
    public static RingPool Instance
    {
        get
        {
            if(instance = null)
            {
                return null;
            }
            return instance;
        }
    }
    private GameObject fireRing1;
    private GameObject fireRing2;

    private GameObject fireRing3;
    private GameObject Monkey1;
    private GameObject Monkey2;

    public static List<GameObject> ringPool;
    public static List<GameObject> monkeyPool;

    private float ring1Num;
    private float ring2Num;
    private float ring3Num;

    private float Monkey1Num;
    private float Monkey2Num;
    private int poolIndex = 0;

    private void Awake() {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start() 
    {
        string sceneName = SceneManager.GetActiveScene().name;
        
        ringPool = new List<GameObject>();

        ring1Num = 5f;
        ring2Num = 3f;
        ring3Num = 2f;

        monkeyPool = new List<GameObject>();

        Monkey1Num = 7f;
        Monkey2Num = 3f;

        //fireRing1 = Resources.Load<GameObject>("Prefabs/FireRing");
        //fireRing2 = Resources.Load<GameObject>("Prefabs/FireRing_2");
        //fireRing3 = Resources.Load<GameObject>("Prefabs/FireRing_3");
        if(sceneName == GData.SCENE_NAME_PLAY)
        {
            for(int i = 0; i < ring1Num; i ++)
            {
                fireRing1 = Instantiate(Resources.Load<GameObject>("Prefabs/FireRing"));
                fireRing1.transform.parent = GFunc.GetRootObj("GameObjs").transform;
                fireRing1.SetActive(false);
                ringPool.Add(fireRing1);
            }
            for(int i = 0; i < ring2Num; i ++)
            {
                fireRing2 = Instantiate(Resources.Load<GameObject>("Prefabs/FireRing_2"));
                fireRing2.transform.parent = GFunc.GetRootObj("GameObjs").transform;
                //fireRing2.transform.parent = this.transform;
                fireRing2.SetActive(false);
                ringPool.Add(fireRing2);
            }
            for(int i = 0; i < ring3Num; i ++)
            {
                fireRing3 = Instantiate(Resources.Load<GameObject>("Prefabs/FireRing_3"));
                fireRing3.transform.parent = GFunc.GetRootObj("GameObjs").transform;
                //fireRing3.transform.parent = this.transform;
                fireRing3.SetActive(false);
                ringPool.Add(fireRing3);
            }

            for(int i = 0; i < 100; i++)
            {
                int ranNum1 = Random.Range(0,ringPool.Count);
                int ranNum2 = Random.Range(0,ringPool.Count);
                GameObject tmp;

                tmp = ringPool[ranNum1];
                ringPool[ranNum1] = ringPool[ranNum2];
                ringPool[ranNum2] = tmp;
            }
        }
        else if(sceneName == GData.SCENE_NAME_PLAY2)
        {
            //Monkey1 = Instantiate(Resources.Load<GameObject>("Prefabs/Monkey1"));

            //test
            for(int i = 0; i < Monkey1Num; i ++)
            {
                Monkey1 = Instantiate(Resources.Load<GameObject>("Prefabs/Monkey1"));
                Monkey1.transform.parent = GFunc.GetRootObj("GameObjs").transform;
                Monkey1.SetActive(false);
                monkeyPool.Add(Monkey1);
            }
            //test


            for(int i = 0; i < Monkey2Num; i ++)
            {
                Monkey2 = Instantiate(Resources.Load<GameObject>("Prefabs/Monkey2"));
                Monkey2.transform.parent = GFunc.GetRootObj("GameObjs").transform;
                //fireRing2.transform.parent = this.transform;
                Monkey2.SetActive(false);
                monkeyPool.Add(Monkey2);
            }
            for(int i = 0; i < 100; i++)
            {
                int ranNum1 = Random.Range(0,monkeyPool.Count);
                int ranNum2 = Random.Range(0,monkeyPool.Count);
                GameObject tmp;

                tmp = monkeyPool[ranNum1];
                monkeyPool[ranNum1] = monkeyPool[ranNum2];
                monkeyPool[ranNum2] = tmp;
            }
        }
    }

    public void MakeRing()
    {
        Debug.Log("동작?");
        if(poolIndex > ringPool.Count)
        {
            poolIndex = 0;
        }
        ringPool[poolIndex].transform.position = Vector2.zero;
        ringPool[poolIndex].SetActive(true);
    }
}
