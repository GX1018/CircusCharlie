using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int life = 3;

    public int score = 0;
    public int bonus = 0;
    public int highScore = 0;

    public bool isClear = false;
    
    public bool isDebugMode = false;

    public float clearAfterTime = 0;
    
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
        string sceneName = SceneManager.GetActiveScene().name;
        
        if(life ==0)
        {
            GFunc.LoadScene(GData.SCENE_NAME_GAMEOVER);
            life = 3;
            highScore = score;
            score = 0;
        }
        
        else if (Input.GetMouseButtonDown(0))
        {
            life--;
            if(sceneName == GData.SCENE_NAME_PLAY)
            {
                GFunc.LoadScene(GData.SCENE_NAME_PLAY);
            }
            else if(sceneName == GData.SCENE_NAME_PLAY)
            {
                GFunc.LoadScene(GData.SCENE_NAME_PLAY2);
            }

        }
    }

    public void Clear()
    {
            Debug.Log("클?");
            Debug.Log($"{isClear}");
            isClear = true;
            string sceneName = SceneManager.GetActiveScene().name;

        if (Input.GetMouseButtonDown(0))
        {
            
            if(sceneName == GData.SCENE_NAME_PLAY)
            {
            score+=bonus;
                isClear=false;
                GFunc.LoadScene(GData.SCENE_NAME_PLAY2);
            }
            else //if(sceneName == GData.SCENE_NAME_PLAY2)
            {
            life = 3;
            highScore = score;
            score = 0;
                GFunc.LoadScene(GData.SCENE_NAME_CLEAR);
                isClear=false;
            }
        }
    }




}
