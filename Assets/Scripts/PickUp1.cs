using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public GameObject explosionFactory;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            // 0���� 9(10-1) ���� ���߿� �ϳ��� �������� �����ͼ�
            int randValue = UnityEngine.Random.Range(0, 10);
            // ���� 3���� ������ �÷��̾����
            if (randValue < 6)
            {
                GameObject explosion = Instantiate(explosionFactory);
                explosion.transform.position = transform.position;
            }
            // �׷��� ������ �Ʒ��������� ���ϰ� �ʹ�.
            

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
