using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
     Rigidbody2D rigid;
     Public int nextMove;
   


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(-1, rigid.velocity.y);
    }

    Void Think()
     {
       
     }
}
