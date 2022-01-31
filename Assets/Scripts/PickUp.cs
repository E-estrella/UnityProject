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
        if (collision.tag.Equals("Player"))
        {
            //����� �Ҵ�(���� ��)
            AudioSource.PlayClipAtPoint(Boom, transform.position);
            Destroy(this.gameObject);
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
