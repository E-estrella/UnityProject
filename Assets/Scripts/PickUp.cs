using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //오디오 할당
    public AudioClip Boom;
    public GameObject explosionFactory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("player1")|| collision.tag.Equals("player2"))
        {
            //오디오 할당(꽝일 때)
            AudioSource.PlayClipAtPoint(Boom, transform.position);
            Destroy(this.gameObject);
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;
        }
    }
}
