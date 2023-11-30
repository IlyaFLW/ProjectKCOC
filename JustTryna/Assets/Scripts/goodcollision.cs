using UnityEngine;
using System.Collections;
//we need this for work with UI
using UnityEngine.UI;
public class CollisionGameObjectExample : MonoBehaviour
{
    public TMPro.TMP_Text ScoreText;
    private int score;
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Good")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            score++;
            ScoreText.text =  score.ToString();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Bad")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            score--;
            ScoreText.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
}