using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
   private bool state;
   bool MonstergameObject = true;
   public GameObject Monster;
   public GameObject player1_outter;
    //float Timer = 0.0f;

    void Start()
    {
        state = true;
        //if(Player1.gameObject == false)
        //{
        //  Timer += Time.deltaTime;

        //if(Timer == 3.0f)
        // {
        //  Player1.gameObject.SetActive(true);
        //   Timer = 0.0f;
        //  }
        //}


    }
    


    //destroy
    void OnTriggerEnter2D(Collider2D collision)
    {
        
       // if (collision.gameObject.tag.Equals("Monster"))
       // {
            //player1_outter.gameObject.SetActive(false);
           Destroy(collision.gameObject);

       // }
    }

    

    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    //MonstergameObject = false;
    //Monster.gameObject.SetActive(false);
    //}


    void Update()
    {


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



    void Update()
    {
         
    }
}
