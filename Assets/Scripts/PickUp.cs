using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //����� �Ҵ�
    public AudioClip Boom;
    public GameObject explosionFactory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("player1")|| collision.tag.Equals("player2"))
        {
            //����� �Ҵ�(���� ��)
            AudioSource.PlayClipAtPoint(Boom, transform.position);
            Destroy(this.gameObject);
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;
        }
    }
}
