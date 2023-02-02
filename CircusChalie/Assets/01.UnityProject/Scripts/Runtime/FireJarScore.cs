using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireJarScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag ==  "Player")
        {
            other.GetComponent<PlayerController>().JumpJar();
            GameManager.Instance.score += 200;
            GFunc.GetRootObj("UiObjs").transform.Find("Ui_Text").GetComponent<Ui_Text>().JumpJar();
        }
    }
}
