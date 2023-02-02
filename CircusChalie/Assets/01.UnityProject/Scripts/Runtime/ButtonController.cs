using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    GameObject player;
    PlayerControll_Button playerControll_Button;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GFunc.GetRootObj("GameObjs").FindChildObj("Player");
        playerControll_Button = player.GetComponent<PlayerControll_Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftButtonDown()
    {
        playerControll_Button.LeftMove = true;
    }
    public void LeftButtonUp()
    {
        playerControll_Button.LeftMove = false;
    }

    public void RightButtonDown()
    {
        playerControll_Button.RightMove = true;
    }
    public void RightButtonUp()
    {
        playerControll_Button.RightMove = false;
    }

    public void JumpButtonDown()
    {
        //playerControll_Button.RightMove = false;
        //playerControll_Button.LeftMove = false;
        playerControll_Button.Jump = true;
    }
    public void JumpButtonUp()
    {
        playerControll_Button.Jump = false;
    }
}
