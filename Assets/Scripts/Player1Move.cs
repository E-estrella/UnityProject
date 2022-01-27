using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Move : MonoBehaviour
{
    // 애니메이터 변수
    Animator anim;

    Rigidbody2D myRigid;

    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();

        anim = GameObject.Find("Player1").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (h > 0)
        {
            transform.localScale = new Vector2(-1, 1);
            anim.SetBool("IdleToRun1", true);
            Move();
        }

        else if (h < 0)
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("IdleToRun1", true);
            Move();
        }

        else anim.SetBool("IdleToRun1", false);
        Move();

        float v = Input.GetAxis("Vertical");
        if (v > 0)
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("moving1", true);
            Move();
        }

        else if (v < 0)
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("moving1", true);
            Move();
        }

        else anim.SetBool("moving1", false);
        Move();
    }

    // 캐릭터 이동(방향, 스피드, Time.deltaTime)
    void Move()
    {
        if(Input.GetKey(KeyCode.W))
        {
            myRigid.AddForce(new Vector2(0, 10));
        }

        if(Input.GetKey(KeyCode.D))
        {
            myRigid.AddForce(new Vector2(10, 0));
        }

        if(Input.GetKey(KeyCode.A))
        {
            myRigid.AddForce(new Vector2(-10, 0));
        }

        if(Input.GetKey(KeyCode.S))
        {
            myRigid.AddForce(new Vector2(0, -10));
        }
    }
}




//Transform player1;
//Vector2 playerPosition;
//CharacterController cc;
//private Vector2 vector;

//player1 = GameObject.Find("Player1").transform;
//cc = GetComponent<CharacterController>();


//enum PlayerState
//{
//    Idle,
//    Run,
//    Attack,
//    Jump
//}

//PlayerState p_State;

//p_State = PlayerState.Idle;

//switch (p_State)
//{
//    case PlayerState.Idle:
//        Idle();
//        break;
//    case PlayerState.Run:
//        Move();
//        break;
//    case PlayerState.Attack:
//        //Attack();
//        break;
//    case PlayerState.Jump:
//        //Jump();
//        break;
//}

//void Idle()
//{
//    if (Input.anyKeyDown)
//    {
//        p_State = PlayerState.Run;
//        print("상태 전환: Idle -> Move");
//    }
//}

//playerPosition = transform.position;

//playerPosition += -Vector2.up * moveSpeed * Time.deltaTime;
//myRigid.MovePosition(playerPosition);
//transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);
