using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireJar : MonoBehaviour
{
    // Start is called before the first frame update
    private RectTransform rectTransform;
    private void Awake() {

        rectTransform = GetComponent<RectTransform>();

        if(transform.parent.name=="0"){
            rectTransform.anchoredPosition = new Vector2(500,-200);
        }
        else
        {
            float ranNum = Random.Range(-550, 550);
            rectTransform.anchoredPosition = new Vector2(ranNum,-200);
        }

        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
