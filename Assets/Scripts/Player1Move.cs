using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Move : MonoBehaviour
{
    Rigidbody2D myRigid;

    Vector2 playerPosition;

    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // 캐릭터 이동(방향, 스피드, Time.deltaTime)
    public void Move()
    {
        playerPosition = transform.position;

        if(Input.GetKey(KeyCode.W))
        {
            

            //playerPosition += Vector2.up * moveSpeed * Time.deltaTime;
            //myRigid.MovePosition(playerPosition);
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
            
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {

            //playerPosition += -Vector2.up * moveSpeed * Time.deltaTime;
            //myRigid.MovePosition(playerPosition);
            transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);
        }
    }

    // 키보드 입력값을 받음
    /*private void GetInput()
    {
        Vector2 moveVector;
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

        direction = moveVector;
    }*/
}
