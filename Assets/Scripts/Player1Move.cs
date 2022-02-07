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
    GameObject playerObj;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();

        playerObj = GameObject.Find("Player1");

        anim = GameObject.Find("Player1").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IdleToRun1", true);
            //transform.localScale = new Vector3(-1, 1, 0);
            playerObj.transform.localScale = new Vector3(-1, 1, 0);
            myRigid.AddForce(new Vector3(10, 0, 0));
        }

        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IdleToRun1", true);
            //transform.localScale = new Vector3(1, 1, 0);
            playerObj.transform.localScale = new Vector3(1, 1, 0);
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