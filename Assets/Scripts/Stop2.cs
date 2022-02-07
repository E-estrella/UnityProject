//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Stop2 : MonoBehaviour
//{
//    public GameObject Monster;
//    bool collgameObject = false;
//    float Timer = 0.0f;
//    int score2;

//    void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.gameObject.tag.Equals("Monster") && collision.gameObject.activeSelf)
//        {

//            //collgameObject = true;


//            Inventory3 inven3 = GetComponent<Inventory3>();
//            GameObject Score = GameObject.Find("ScoreManager");
//            Score score = Score.GetComponent<Score>();
//            score2 = score.Player2Score;

//            if (collision.gameObject.tag.Equals("Monster"))
//            {

//                if (score2 >= 1)
//                {
//                    print("충돌");
//                    collision.gameObject.SetActive(false);
//                    collgameObject = true;
//                    StopMonster();
//                }

//                if (score2 == 0)
//                {
//                    Destroy(this.gameObject);
//                }
//            }
//        }
//    }

//    private void StopMonster()
//    {
//        if (collgameObject)
//        {
//            Timer += Time.deltaTime;
//            print("제발");

//            if (Timer > 3.0f)
//            {
//                print("나타나!");
//                Monster.gameObject.SetActive(true);


//                Timer = 0.0f;
//                collgameObject = false;
//            }
//        }
//    }
//}