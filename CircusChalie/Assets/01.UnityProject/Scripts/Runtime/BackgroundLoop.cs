using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackgroundLoop : MonoBehaviour
{
    private RectTransform rectTransform;
    //private TMP_Text signText;

    // Start is called before the first frame update
    private void Start() {
        rectTransform = GetComponent<RectTransform>();
        for(int i = 0; i<11; i++){
            int signNum = 0;
            string a = i.ToString();
            if(gameObject.name==$"bg{a}"){
                rectTransform.anchoredPosition = new Vector2(i*1280,0);

                signNum = 100 - 10*i;
                transform.Find("Sign").GetComponent<TMP_Text>().text = $"{signNum}m";

                if(i == 0)
                {
                    transform.Find("LeftWall").gameObject.SetActive(true);
                }
                if(i == 10)
                {
                    transform.Find("RightWall").gameObject.SetActive(true);
                    transform.Find("Goal").gameObject.SetActive(true);
                }
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
