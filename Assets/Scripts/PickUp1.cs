using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public GameObject explosionFactory;
    public GameObject explosionFactory2;
    public GameObject slotItem;
    //����� Ŭ��
    public AudioClip Boom;
    public AudioClip Get;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //����� Ŭ��
        

        if (collision.tag.Equals("player1")|| collision.tag.Equals("player2"))
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
                Destroy(this.gameObject);
            }
            // �׷��� ������
            else
            {
                GameObject explosion = Instantiate(explosionFactory2);
                explosion.transform.position = transform.position;
                AudioSource.PlayClipAtPoint(Get, transform.position);
                //Destroy(this.gameObject);
                if (collision.tag.Equals("Player1"))
                {
                    Inventory1 inven = collision.GetComponent<Inventory1>();
                    for (int i = 0; i < inven.slots.Count; i++)
                    {
                        if(inven.slots[i].isEmpty)
                        {
                            Instantiate(slotItem, inven.slots[i].slotObj.transform, false);
                            inven.slots[i].isEmpty = false;
                            Destroy(this.gameObject);
                            break;
                        }

                    }
                }
            }
            //Destroy(this.gameObject);     
        }
            

     
    }
    
}
