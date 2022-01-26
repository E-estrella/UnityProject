using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Move : MonoBehaviour
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
        //playerPosition = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {


            //playerPosition += Vector2.up * moveSpeed * Time.deltaTime;
            //myRigid.MovePosition(playerPosition);
            //transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

            myRigid.AddForce(new Vector2(0, 10));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            myRigid.AddForce(new Vector2(10, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            //transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
            myRigid.AddForce(new Vector2(-10, 0));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            //playerPosition += -Vector2.up * moveSpeed * Time.deltaTime;
            //myRigid.MovePosition(playerPosition);
            //transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);

            myRigid.AddForce(new Vector2(0, -10));
        }
    }
}
