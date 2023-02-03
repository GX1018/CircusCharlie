using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui_Text : MonoBehaviour
{
    float timeAfterStart = 0;
    int bonus = 5000;
    int score = 0000;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        GameManager.Instance.bonus = bonus;
        
        timeAfterStart += Time.deltaTime;
        if(timeAfterStart >1&&GameManager.Instance.isClear==false)
        {
            bonus -= 10;
            timeAfterStart = 0;
            
        }
        gameObject.GetComponent<TMP_Text>().text = $"SCORE - {GameManager.Instance.score:D8} \t HI - {GameManager.Instance.highScore:D8}\t STAGE - 01\nLife - {GameManager.Instance.life}\t BONUS - {bonus}";

    }
    public void GettingGold()
    {
        score += 500;
    }

    public void JumpJar()
    {
        score += 200;
    }

    public void JumpFireRing()
    {
        score += 100;
    }
}
