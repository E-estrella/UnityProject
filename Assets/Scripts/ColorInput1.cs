using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorInput1 : MonoBehaviour
{
    //public int tile1;
    public Vector3 PlayerPosition;
    public LayerMask whatisPlatform;
    public g2_time settime;

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(PlayerPosition, 0.2f);
        settime = GameObject.Find("Main Camera").GetComponent<g2_time>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = transform.position;

        if (settime.setTime > 0)
        {
            Collider2D overCollider2d = Physics2D.OverlapCircle(PlayerPosition, 0.01f, whatisPlatform);
            if (overCollider2d != null)
            {
                Bricks1 brk1 = overCollider2d.transform.GetComponent<Bricks1>();

                if (brk1)
                {
                    brk1.MakeColor(PlayerPosition);
                }
            }
        }
    }
}
