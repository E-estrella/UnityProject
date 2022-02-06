using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Move : MonoBehaviour
{
    // 애니메이터 변수
    Animator anim;

    Rigidbody2D myRigid;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();

        anim = GameObject.Find("Player1").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IdleToRun1", true);
            transform.localScale = new Vector3(-1, 1, 0);
            myRigid.AddForce(new Vector3(10, 0, 0));
        }

        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IdleToRun1", true);
            transform.localScale = new Vector3(1, 1, 0);
            myRigid.AddForce(new Vector3(-10, 0, 0));
        }

        else anim.SetBool("IdleToRun1", false);

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("moving1", true);
            transform.localScale = new Vector3(1, 1, 0);
            myRigid.AddForce(new Vector3(0, 10, 0));
        }

        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("moving1", true);
            transform.localScale = new Vector3(1, 1, 0);
            myRigid.AddForce(new Vector3(0, -10, 0));
        }

        else anim.SetBool("moving1", false);
    }
}





























    
// 키보드 입력값을 받음
    /*private Vector2 GetInput()
    {
        Vector2 moveVector;
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

        Vector2 direction = moveVector;
        return direction;
    }*/

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


// 캐릭터 이동(방향, 스피드, Time.deltaTime)
//void Move()
//{
//    if(Input.GetKey(KeyCode.W))
//    {
//        myRigid.AddForce(new Vector2(0, 10));
//    }

//    if(Input.GetKey(KeyCode.D))
//    {
//        myRigid.AddForce(new Vector2(10, 0));
//    }

//    if(Input.GetKey(KeyCode.A))
//    {
//        myRigid.AddForce(new Vector2(-10, 0));
//    }

//    if(Input.GetKey(KeyCode.S))
//    {
//        myRigid.AddForce(new Vector2(0, -10));
//    }
//}
