using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop2 : MonoBehaviour
{
    public GameObject Monster;
    bool collgameObject = false;
    float Timer = 0.0f;
    int score2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Monster") && collision.gameObject.activeSelf)
        {
            collision.gameObject.SetActive(false);

            print("Ãæµ¹!");

            Inventory3 inven3 = GetComponent<Inventory3>();
            GameObject Score = GameObject.Find("ScoreManager");
            Score score = Score.GetComponent<Score>();
            score2 = score.Player2Score;

            if (collision.gameObject.tag.Equals("Monster"))
            {

                if (score2 >= 1)
                {
                    collision.gameObject.SetActive(false);
                    collgameObject = true;
                }

                collgameObject = true;

                if (score2 == 0)
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


            if (Timer > 5.0f)
            {
                Monster.gameObject.SetActive(true);


                Timer = 0.0f;
                collgameObject = false;
            }
        }
    }
}
