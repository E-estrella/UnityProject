using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public GameObject explosionFactory;
    public GameObject explosionFactory2;
    public GameObject slotItem;
    public GameObject slotItem2;
    //����� Ŭ��
    public AudioClip Boom;
    public AudioClip Get;
    public int plus;
    public int Count;
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
                if (collision.tag.Equals("player1"))
                {
                    Inventory1 inven1 = collision.GetComponent<Inventory1>();
                    for (int i = 0; i < inven1.slots.Count; i++)
                    {
                        if(inven1.slots[i].isEmpty)
                        {
                            Instantiate(slotItem, inven1.slots[i].slotObj.transform, false);
                            inven1.slots[i].isEmpty = false;
                            plus++;
                            Debug.Log(plus);
                            Destroy(this.gameObject);
                            break;
                        }
                        if (plus == 1)
                        {
                            Count++;
                        }
                    }
                    
                    //Count = count++;
                    Debug.Log(Count);
                }
                

                else if (collision.tag.Equals("player2"))
                {
                    Inventory2 inven = collision.GetComponent<Inventory2>();
                    for (int i = inven.slots.Count-1; i >= 0; i--)
                    {
                        if (inven.slots[i].isEmpty)
                        {
                            Instantiate(slotItem2, inven.slots[i].slotObj2.transform, false);
                            inven.slots[i].isEmpty = false;
                            Destroy(this.gameObject);
                            break;
                        }

                    }
                }
                Destroy(this.gameObject);
            }
            //Destroy(this.gameObject);     
        }
    }
}
