using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPocket : MonoBehaviour
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
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerController>().GettingGold();
            GameManager.Instance.score +=500;
            GFunc.GetRootObj("UiObjs").transform.Find("Ui_Text").GetComponent<Ui_Text>().GettingGold();
            gameObject.SetActive(false);
        }
    }
}
