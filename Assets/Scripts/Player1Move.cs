using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Move : MonoBehaviour
{
    // 애니메이터 변수
    Animator anim;

    Rigidbody2D myRigid;

    Vector2 playerPosition;

    Transform player1;

    public float moveSpeed = 1.0f;

    CharacterController cc;

    enum PlayerState
    {
        Idle,
        Run,
        Attack,
        Jump
    }

    //PlayerState p_State;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        //p_State = PlayerState.Idle;

        //player1 = GameObject.Find("Player1").transform;

        //cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //float h = Input.GetAxis("Horizontal");
        //if (h > 0)
        //{
        //    transform.localScale = new Vector2(-1, 1);
        //    anim.SetBool("IdleToRun", true);
        //    Move();
        //}

        //else if (h < 0)
        //{
        //    transform.localScale = new Vector2(1, 1);
        //    anim.SetBool("IdleToRun", true);
        //    Move();
        //}

        //else anim.SetBool("IdleToRun", false);


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
    }

    //void Idle()
    //{
    //    if(Input.anyKeyDown)
    //    {
    //        p_State = PlayerState.Run;
    //        print("상태 전환: Idle -> Move");
    //    }
    //}

    // 캐릭터 이동(방향, 스피드, Time.deltaTime)
    public void Move()
    {
        //playerPosition = transform.position;

        if(Input.GetKey(KeyCode.W))
        {


            //playerPosition += Vector2.up * moveSpeed * Time.deltaTime;
            //myRigid.MovePosition(playerPosition);
            //transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

            myRigid.AddForce(new Vector2(0, 10));
        }

        if(Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            myRigid.AddForce(new Vector2(10, 0));
        }

        if(Input.GetKey(KeyCode.A))
        {

            //transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
            myRigid.AddForce(new Vector2(-10, 0));
        }

        if(Input.GetKey(KeyCode.S))
        {

            //playerPosition += -Vector2.up * moveSpeed * Time.deltaTime;
            //myRigid.MovePosition(playerPosition);
            //transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);

            myRigid.AddForce(new Vector2(0, -10));
        }
    }
}
