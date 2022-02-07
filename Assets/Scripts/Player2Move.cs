using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Move : MonoBehaviour
{
    Rigidbody2D myRigid;
    Animator anim;
    public float moveSpeed;
    GameObject playerObj;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        anim = GameObject.Find("Player2").GetComponent<Animator>();
        playerObj = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerObj.transform.localScale = new Vector2(-1, 1);
            anim.SetBool("IdleToRun", true);
            myRigid.AddForce(new Vector2(10, 0));
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerObj.transform.localScale = new Vector2(1, 1);
            anim.SetBool("IdleToRun", true);
            myRigid.AddForce(new Vector2(-10, 0));
        }

        else anim.SetBool("IdleToRun", false);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("moving", true);
            myRigid.AddForce(new Vector2(0, 10));
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("moving", true);
            myRigid.AddForce(new Vector2(0, -10));
        }

        else anim.SetBool("moving", false);
    }
}