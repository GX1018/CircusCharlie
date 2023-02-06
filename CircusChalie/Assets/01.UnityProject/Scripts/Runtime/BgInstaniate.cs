using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgInstaniate : MonoBehaviour
{
    public GameObject bgPrefab;//private으로 교체
    // Start is called before the first frame update
    void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if(sceneName == GData.SCENE_NAME_PLAY)
        {
            
            bgPrefab = Resources.Load<GameObject>("Prefabs/BgImage");
    
            for(int i = 0; i<11; i++)
            {
                GameObject bgImage = Instantiate(bgPrefab,gameObject.transform);
                bgImage.name = $"bg{i}";
            }
        }
        else if(sceneName == GData.SCENE_NAME_PLAY2)
        {
            
            bgPrefab = Resources.Load<GameObject>("Prefabs/Stage2BgImage");
    
            for(int i = 0; i<11; i++)
            {
                GameObject bgImage = Instantiate(bgPrefab,gameObject.transform);
                bgImage.name = $"bg{i}";
            }
        }
        if(sceneName == GData.SCENE_NAME_Debug)
        {
            
            bgPrefab = Resources.Load<GameObject>("Prefabs/BgImage");
    
            for(int i = 0; i<11; i++)
            {
                GameObject bgImage = Instantiate(bgPrefab,gameObject.transform);
                bgImage.name = $"bg{i}";
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
