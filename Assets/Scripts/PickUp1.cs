using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public GameObject explosionFactory;
    public GameObject explosionFactory2;
    public GameObject slotItem;
    //오디오 클립
    public AudioClip Boom;
    public AudioClip Get;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //오디오 클립
        

        if (collision.tag.Equals("Player"))
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

            }
            // 그렇지 않으면
            else
            {
                GameObject explosion = Instantiate(explosionFactory2);
                explosion.transform.position = transform.position;
                Inventory inven = collision.GetComponent<Inventory>();
                //Destroy(this.gameObject);
                for(int i=0; i<inven.slots.Count; i++)
                {
                    if (inven.slots[i].isEmpty)
                    {
                        Instantiate(slotItem, inven.slots[i].slotObj.transform,false);
                        inven.slots[i].isEmpty = false;
                        Destroy(this.gameObject);
                        break;
                    }
                    //오디오 할당(얻었을 때)
                    AudioSource.PlayClipAtPoint(Get, transform.position);
                    Destroy(this.gameObject);
                }
                
            }
            Destroy(this.gameObject);

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
