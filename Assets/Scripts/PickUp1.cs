using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public GameObject explosionFactory;
    public GameObject explosionFactory2;
    //public GameObject slotItem;
    //����� Ŭ��
    public AudioClip Boom;
    public AudioClip Get;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //����� Ŭ��
        

        if (collision.tag.Equals("Player"))
        {
            
            // 0���� 9(10-1) ���� ���߿� �ϳ��� �������� �����ͼ�
            int randValue = UnityEngine.Random.Range(0, 10);
            if (randValue < 5)
            {
                GameObject explosion = Instantiate(explosionFactory);
                explosion.transform.position = transform.position;
                //Destroy(this.gameObject);
                //����� �Ҵ�(���� ��)
                AudioSource.PlayClipAtPoint(Boom, transform.position);

            }
            // �׷��� ������
            else
            {
                GameObject explosion = Instantiate(explosionFactory2);
                explosion.transform.position = transform.position;
                AudioSource.PlayClipAtPoint(Get, transform.position);
                //Destroy(this.gameObject);
            }
            Destroy(this.gameObject);     
        }
            

     
    }
    
}
