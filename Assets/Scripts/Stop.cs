using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
   
   public GameObject Monster;
    bool collgameObject = true;
    float Timer = 0.0f;

    void Start()
    {
      


    }
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        
       if (collision.gameObject.tag.Equals("Monster"))
        {
           collision.gameObject.SetActive(false);
           //Destroy(collision.gameObject);

        }
    }

    



    void Update()
    {

    //private void OnTriggerEnter(Collider2D collision)
    //{
    //    if()
    //}

        if(!collgameObject)
        {
          Timer += Time.deltaTime;


          if(Timer <= 3.0f)
           {
             Monster.gameObject.SetActive(true);
             collgameObject = true;


             Timer = 0.0f;
           }
        }


    }
}
