using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class lvl1popupfail : MonoBehaviour
{
    public TMPro.TMP_Text ScoreText;
    
    public GameObject ext;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreText.text == "-1")
        {
            Time.timeScale = 0;
            ext.SetActive(true);
            
        }
    }
    
    
}
