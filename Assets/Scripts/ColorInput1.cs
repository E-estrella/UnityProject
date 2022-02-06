using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorInput1 : MonoBehaviour
{
    Vector3 PlayerPosition;
    public LayerMask whatisPlatform;

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(PlayerPosition, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = transform.position;

        //if (Input.GetKey(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        {

            Collider2D overCollider2d = Physics2D.OverlapCircle(PlayerPosition, 0.01f, whatisPlatform);
            if (overCollider2d != null)
            {
                print("Ãæµ¹!!");

                overCollider2d.transform.GetComponent<Bricks1>().MakeColor(PlayerPosition);
            }
        }
    }
}
