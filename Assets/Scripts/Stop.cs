using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{

    public GameObject Monster;
    bool collgameObject = false;
    float Timer = 0.0f;
    int score1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Monster") && collision.gameObject.activeSelf)
        {
            collision.gameObject.SetActive(false);
           

            print("충돌");

            //collgameObject = true;

            Inventory3 inven3 = GetComponent<Inventory3>();
            GameObject Score = GameObject.Find("ScoreManager");
            Score score = Score.GetComponent<Score>();
            score1 = score.Player1Score;

            if (collision.gameObject.tag.Equals("Monster"))
            {

                if (score1 >= 1)
                {
                    collision.gameObject.SetActive(false);
                    collgameObject = true;
                }

                collgameObject = true;

                if (score1 == 0)
                {
                    collision.gameObject.SetActive(true);
                    Destroy(this.gameObject);
                    collgameObject = true;
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
