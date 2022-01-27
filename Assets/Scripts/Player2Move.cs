using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Move : MonoBehaviour
{
    Rigidbody2D myRigid;
    Animator anim;
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        anim = GameObject.Find("Player2").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (h > 0)
        {
            transform.localScale = new Vector2(-1, 1);
            anim.SetBool("IdleToRun", true);
            Move();
        }

        else if (h < 0)
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("IdleToRun", true);
            Move();
        }

        else anim.SetBool("IdleToRun", false);
        Move();

        float v = Input.GetAxis("Vertical");
        if (v > 0)
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("moving", true);
            Move();
        }

        else if (v < 0)
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("moving", true);
            Move();
        }

        else anim.SetBool("moving", false);
        Move();
    }
   
    // 캐릭터 이동(방향, 스피드, Time.deltaTime)
    void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigid.AddForce(new Vector2(0, 10));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigid.AddForce(new Vector2(10, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigid.AddForce(new Vector2(-10, 0));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigid.AddForce(new Vector2(0, -10));
        }
    }
}




//Transform player2;

//CharacterController cc;
//PlayerState p_State;

//Vector2 playerPosition;

//enum PlayerState
//{
//    Idle,
//    Run,
//    Attack,
//    Jump
//}

//p_State = PlayerState.Idle;

//player2 = GameObject.Find("Player2").transform;

//cc = GetComponent<CharacterController>();

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

//playerPosition += Vector2.up * moveSpeed * Time.deltaTime;
//myRigid.MovePosition(playerPosition);
//transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

//transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

//transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);

//playerPosition += -Vector2.up * moveSpeed * Time.deltaTime;
//myRigid.MovePosition(playerPosition);
//transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);