using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftInput : MonoBehaviour
{
    Vector3 PlayerPosition;
    public LayerMask whatisPlatform;

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(PlayerPosition, 0.2f);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        {
            print("키입력");

            Collider2D overCollider2d = Physics2D.OverlapCircle(PlayerPosition, 0.01f, whatisPlatform);
            if(overCollider2d != null)
            {
                print("충돌!!");

                overCollider2d.transform.GetComponent<Bricks>().MakeColor(PlayerPosition);
            }
        }
    }
}
