using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTouched : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            GFunc.LoadScene(GData.SCENE_NAME_PLAY);
        }
    }
}
