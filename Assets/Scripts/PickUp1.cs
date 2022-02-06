using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public GameObject explosionFactory;
    public GameObject explosionFactory2;
    public GameObject slotItem;
    public GameObject slotItem2;
    //오디오 클립
    public AudioClip Boom;
    public AudioClip Get;
    public int plus1, plus2;
    public int Count1, Count2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //오디오 클립


        if (collision.tag.Equals("player1") || collision.tag.Equals("player2"))
        {

            // 0부터 9(10-1) 까지 값중에 하나를 랜덤으로 가져와서
            int randValue = UnityEngine.Random.Range(0, 10);
            if (randValue < 5)
            {
                GameObject explosion = Instantiate(explosionFactory);
                explosion.transform.position = transform.position;
                //Destroy(this.gameObject);
                //오디오 할당(꽝일 때)
                AudioSource.PlayClipAtPoint(Boom, transform.position);
                Destroy(this.gameObject);
            }
            // 그렇지 않으면
            else
            {
                GameObject explosion = Instantiate(explosionFactory2);
                explosion.transform.position = transform.position;
                AudioSource.PlayClipAtPoint(Get, transform.position);
                if (collision.tag.Equals("player1"))
                {
                    Inventory1 inven1 = collision.GetComponent<Inventory1>();
                    int i;
                    for (i = 0; i < inven1.slots.Count; i++)
                    {
                        if (inven1.slots[i].isEmpty)
                        {
                            Instantiate(slotItem, inven1.slots[i].slotObj.transform, false);
                            inven1.slots[i].isEmpty = false;
                            plus1++;
                            if (plus1 == 1)
                            {
                                Count1++;
                            }
                            Destroy(this.gameObject);
                            break;
                        }
                        Count1++;
                    }
                    Debug.Log(Count1);
                }
                g1_time time = GameObject.Find("Main Camera").GetComponent<g1_time>();
                if (time.setTime <= 0)
                {
                    GameObject.Find("player1_outter").GetComponent<Score>().Plus();
                }

                else if (collision.tag.Equals("player2"))
                {
                    Inventory2 inven = collision.GetComponent<Inventory2>();
                    for (int i = inven.slots.Count - 1; i >= 0; i--)
                    {
                        if (inven.slots[i].isEmpty)
                        {
                            Instantiate(slotItem2, inven.slots[i].slotObj2.transform, false);
                            inven.slots[i].isEmpty = false;
                            plus2++;
                            if(plus2 == 1)
                            {
                                Count2++;
                            }
                            Destroy(this.gameObject);
                            break;
                        }
                        Count2++;
                    }
                    Debug.Log(Count2);
                    //GameObject.Find("player2_outter").GetComponent<Score>().Plus();
                }
                Destroy(this.gameObject);
            }
            //Destroy(this.gameObject);     
        }
    }
}
