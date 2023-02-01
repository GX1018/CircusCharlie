using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private RectTransform rectTransform;

    // Start is called before the first frame update
    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        for(int i = 0; i<10; i++){
            string a = i.ToString();
            if(gameObject.name==a){
                rectTransform.anchoredPosition = new Vector2(i*1280,0);
            }
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void Reposition(){

    }
}
