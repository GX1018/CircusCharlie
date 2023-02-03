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
        
    }
    
    public void btnClick()
    {
        if(Input.GetMouseButtonUp(0))
        {
            GameManager.Instance.isDebugMode = false;
            GFunc.LoadScene(GData.SCENE_NAME_PLAY);
        }
    }
    public void GoToDebugMode()
    {
        if(Input.GetMouseButtonUp(0))
        {
            GameManager.Instance.isDebugMode = true;
            GFunc.LoadScene(GData.SCENE_NAME_Debug);
        }
    }
}
