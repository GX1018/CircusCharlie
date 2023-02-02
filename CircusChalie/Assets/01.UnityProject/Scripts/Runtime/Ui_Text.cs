using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui_Text : MonoBehaviour
{
    float timeAfterStart = 0;
    float bonus = 5000;
    float score = 0000;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterStart += Time.deltaTime;
        if(timeAfterStart >1)
        {
            bonus -= 10;
            timeAfterStart = 0;
            
        }
        gameObject.GetComponent<TMP_Text>().text = $"SCORE - {score} \t BONUS - {bonus}\t STAGE - 01";
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
