using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool; 
public class BgPool : MonoBehaviour
{
    private GameObject bgImagePrefab;
    Stack<GameObject> bgStack;
    public float prefabNum;

    
    
    // Start is called before the first frame update
    void Start()
    {
        bgStack  = new Stack<GameObject>();
        for(int i=0; i<prefabNum; i++ )
        {
            GameObject gameObject = Instantiate(bgImagePrefab);
            bgStack.Push(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
