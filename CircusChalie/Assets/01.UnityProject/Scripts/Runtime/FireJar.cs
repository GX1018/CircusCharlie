using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireJar : MonoBehaviour
{
    // Start is called before the first frame update
    private RectTransform rectTransform;
    private void Start() {

        rectTransform = GetComponent<RectTransform>();

        if(transform.parent.name=="bg0"){
            rectTransform.anchoredPosition = new Vector2(500,-200);
        }
        else
        {
            float ranNum = Random.Range(-550, 550);
            rectTransform.anchoredPosition = new Vector2(ranNum,-200);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null){
                playerController.Die();
            }
        }
    }
}
