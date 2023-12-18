using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class pairGame : MonoBehaviour
{
    public int[] bo;

    public int match = 0;

    int vic = 0;
    //Всю эту залупу надо в массивы
    public Button[] elm;
    
    public Sprite[] pic;
   
    public Sprite closed;

    public int tmp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //checking clicked images
    public void c1()
    {
        bo[0] = 1;
        ChangeSprite(pic[0], elm[0]);
        elm[0].interactable = false;
        checker(ref bo[0], ref bo[3], elm[0]);
        if (tmp == 0)
        {
            tmp = 1;
        }
        else 
        {
            if (match == -1)
            {
                bo[0] = 0;
                bo[tmp - 1] = 0;
            }
            tmp = 0; 
        }
        
    }
    public void c2()
    {
        bo[1] = 1;
        ChangeSprite(pic[1], elm[1]);
        elm[1].interactable = false;
        checker(ref bo[1], ref bo[4], elm[1]);
        if (tmp == 0)
        {
            tmp = 2;
        }
        else { tmp = 0; }
    }
    public void c3() 
    {
        bo[2] = 1;
        ChangeSprite(pic[2], elm[2]);
        elm[2].interactable = false;
        checker(ref bo[2], ref bo[5], elm[2]);
        if (tmp == 0)
        {
            tmp = 3;
        }
        else { tmp = 0; }
    }
    public void c4() 
    {
        bo[3] = 1;
        ChangeSprite(pic[0], elm[3]);
        elm[3].interactable = false;
        checker(ref bo[3], ref bo[0], elm[3]);
        if (tmp == 0)
        {
            tmp = 4;
        }
        else { tmp = 0; }
    }
    public void c5()
    {
        bo[4] = 1;
        ChangeSprite(pic[1], elm[4]);
        elm[4].interactable = false;
        checker(ref bo[4], ref bo[1], elm[4]);
        if (tmp == 0)
        {
            tmp = 5;
        }
        else { tmp = 0; }
    }
    public void c6() 
    {
        bo[5] = 1;
        ChangeSprite(pic[2], elm[5]);
        elm[5].interactable = false;
        checker(ref bo[5], ref bo[2], elm[5]);
        if (tmp == 0)
        {
            tmp = 6;
        }else { tmp = 0; }
    }
    void ChangeSprite(Sprite a, Button q)
    {
        q.image.sprite = a;
    }

    public void checker(ref int a, ref int b, Button aa)
    {
        
        if (a != b && tmp > 0)
        {
            //waiter();
            ChangeSprite(closed, aa);
            ChangeSprite(closed, elm[tmp - 1]);
            bo[tmp - 1] = 0;
            a = 0;
            aa.interactable = true;
            elm[tmp - 1].interactable = true;
            match = -1;
            
            
            
        }else if (a == b && tmp > 0)
        {
            match = 1;
            vic++;
        }
    }

    

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(2);
    }
    }
