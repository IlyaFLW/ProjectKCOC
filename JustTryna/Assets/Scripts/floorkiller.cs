using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class floorkiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Good")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Bad")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            
            Destroy(collision.gameObject);
        }
    }
}
