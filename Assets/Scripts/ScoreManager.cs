using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text Player1ScoreUI;
    public Text Player2ScoreUI;

    public int Player1Score;
    public int Player2Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // ���� ���ڸ� �� ������ ���� ǥ��
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Player1Score++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
