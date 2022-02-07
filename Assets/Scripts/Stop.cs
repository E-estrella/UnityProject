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
    

    //void OnTriggerEnter2D(Collider2D collision)
    //{
        
       //if (collision.gameObject.tag.Equals("Monster"))
        //{
           //collision.gameObject.SetActive(false);
           ///Destroy(collision.gameObject);

        //}
    //}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("player1")|| collision.tag.Equals("player2"))
        {
            if(collision.tag.Equals("player1"))
            {
                Inventory3 inven3 = collision.GetComponent<Inventory3>();
                for(int i = inven3.slots.Count - 1; i >= 0; i--)
                {
                    if(inven3.slots[i].isEmpty)
                    {
                        Destroy(this.gameObject);
                        break;
                    }
                }
            }

            else if(collision.tag.Equals("player2"))
            {
                Inventory4 inven4 = collision.GetComponent<Inventory4>();
                for(int i = inven4.slots.Count - 1; i >= 0;i--)
                {
                    if(inven4.slots[i].isEmpty)
                    {
                        Destroy(this.gameObject);
                        break;
                    }
                }
            }
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
