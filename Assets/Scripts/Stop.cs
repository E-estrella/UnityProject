using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{

    public GameObject Monster;
    bool collgameObject = false;
    float Timer = 0.0f;

    void Start()
    {



    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Monster") && collision.gameObject.activeSelf)
        {
            collision.gameObject.SetActive(false);
            
            print("충돌");

            collgameObject = true;
        }


        if (collision.tag.Equals("player1") || collision.tag.Equals("player2"))
        {
            if (collision.tag.Equals("player1"))
            {
                Inventory3 inven3 = collision.GetComponent<Inventory3>();
                for (int i = inven3.slots.Count - 1; i >= 0; i--)
                {
                    if (inven3.slots[i].isEmpty)
                    {
                        Destroy(this.gameObject);
                        break;
                    }
                }
            }

            else if (collision.tag.Equals("player2"))
            {
                Inventory4 inven4 = collision.GetComponent<Inventory4>();
                for (int i = inven4.slots.Count - 1; i >= 0; i--)
                {
                    if (inven4.slots[i].isEmpty)
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

        if (collgameObject)
        {
            Timer += Time.deltaTime;


            if (Timer > 3.0f)
            {
                Monster.gameObject.SetActive(true);


                Timer = 0.0f;
                collgameObject = false;
            }
        }
    }
}
