using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public GameObject explosionFactory;
    public GameObject explosionFactory2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            // 0부터 9(10-1) 까지 값중에 하나를 랜덤으로 가져와서
            int randValue = UnityEngine.Random.Range(0, 10);
            // 만약 3보다 작으면 플레이어방향
            if (randValue < 5)
            {
                GameObject explosion = Instantiate(explosionFactory);
                explosion.transform.position = transform.position;
            }
            // 그렇지 않으면 아래방향으로 정하고 싶다.
            else
            {
                GameObject explosion = Instantiate(explosionFactory2);
                explosion.transform.position = transform.position;
            }

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
