using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int life = 3;

    public int score = 0;
    public int highScore = 0;
    
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void Die()
    {
        if(life ==0)
        {
            GFunc.LoadScene(GData.SCENE_NAME_TITLE);
            life = 3;
            highScore = score;
            score = 0;
        }
        
        else if (Input.GetMouseButtonDown(0))
        {
            life--;
            GFunc.LoadScene(GData.SCENE_NAME_PLAY);
        }
    }




}
