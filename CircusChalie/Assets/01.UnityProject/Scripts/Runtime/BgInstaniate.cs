using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgInstaniate : MonoBehaviour
{
    public GameObject bgPrefab;//private으로 교체
    // Start is called before the first frame update
    void Start()
    {
        bgPrefab = Resources.Load<GameObject>("Prefabs/BgImage");

        for(int i = 0; i<11; i++)
        {
            GameObject bgImage = Instantiate(bgPrefab,gameObject.transform);
            bgImage.name = $"bg{i}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
